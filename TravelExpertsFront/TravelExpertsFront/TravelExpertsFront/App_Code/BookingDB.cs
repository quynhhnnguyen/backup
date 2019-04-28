using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsFront.App_Code
{
    /* Booking and Booking Detail Data Access - provide function(s) to load data from database.
     * Author: Jonathan Pirca
     * Helper: Quynh Nguyen (Queenie)
     * Created Date: Jan 2019
     */
    public static class BookingDB
    {
        // Method to Get All Bookings and their Booking Details by Customer Id
        public static List<Booking> GetBookingDetails(int CustId)
        {
            List<Booking> bookingList = new List<Booking>();
            Booking preBooking = new Booking();

            string sql = "SELECT BookingId,CustomerId,BookingDate,BookingNo,TravelerCount,TripTypeId,TTName,BookingDetailId," +
                "ItineraryNo,TripStart,TripEnd,Description,Destination,BasePrice,AgencyCommission,RegionId,RegionName," +
                "ClassId,ClassName,FeeId,FeeName,ProductSupplierId,ProdName,SupName, PackageId " +
                "FROM GetOrderDetailsByID WHERE CustomerId = @Param1 ORDER BY BookingDate ASC, BookingId ASC";

            using (SqlConnection conn = TravelExpertsDBConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Param1", CustId);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Booking booking = new Booking();
                            BookingDetails bookingDetail = new BookingDetails();
                            int bookingId = Convert.ToInt32(reader["BookingId"]);

                            if (preBooking.BookingId == bookingId) // the same booking, multiple booking details
                            {
                                booking = preBooking;
                                bookingList.Remove(booking);
                            }
                            else // next booking
                            {
                                booking.BookingId = bookingId;
                                booking.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                                booking.BookingDate = Convert.ToDateTime(reader["BookingDate"]);
                                booking.BookingNo = Convert.ToString(reader["BookingNo"]);
                                booking.TravelerCount = Convert.ToDecimal(reader["TravelerCount"]);
                                booking.TripTypeId = Convert.ToChar(reader["TripTypeId"]);
                                booking.TTName = Convert.ToString(reader["TTName"]);
                                booking.BookingDetails = new List<BookingDetails>();
                                if (reader["PackageId"] == System.DBNull.Value)
                                {
                                    booking.PackageName = "";
                                }
                                else
                                {
                                    using (SqlConnection con = TravelExpertsDBConnection.GetConnection())
                                    {   // get Package Information
                                        using (SqlCommand pkgCmd = new SqlCommand("SELECT PkgName FROM Packages WHERE PackageId = @PackageId ", con))
                                        {
                                            con.Open();
                                            pkgCmd.Parameters.AddWithValue("PackageId", reader["PackageId"].ToString());
                                            SqlDataReader pkgReader = pkgCmd.ExecuteReader();
                                            while (pkgReader.Read())
                                            {
                                                booking.PackageName = pkgReader["PkgName"].ToString();
                                            }
                                        }
                                    }
                                }
                            }

                            // load booking detail
                            bookingDetail.BookingDetailId = Convert.ToInt32(reader["BookingDetailId"]);
                            bookingDetail.ItineraryNo = Convert.ToDecimal(reader["ItineraryNo"]);
                            bookingDetail.TripStart = Convert.ToDateTime(reader["TripStart"]);
                            bookingDetail.TripEnd = Convert.ToDateTime(reader["TripEnd"]);
                            bookingDetail.Description = Convert.ToString(reader["Description"]);
                            bookingDetail.Destination = Convert.ToString(reader["Destination"]);
                            bookingDetail.BasePrice = Convert.ToDecimal(reader["BasePrice"]);
                            bookingDetail.AgencyCommission = Convert.ToDecimal(reader["AgencyCommission"]);
                            bookingDetail.RegionName = Convert.ToString(reader["RegionName"]);
                            bookingDetail.ClassName = Convert.ToString(reader["ClassName"]);
                            bookingDetail.FeeName = Convert.ToString(reader["FeeName"]);
                            bookingDetail.ProdName = Convert.ToString(reader["ProdName"]);
                            bookingDetail.SupName = Convert.ToString(reader["SupName"]);

                            booking.BookingDetails.Add(bookingDetail);
                            booking.TotalCost += bookingDetail.BasePrice + bookingDetail.AgencyCommission;
                            booking.Destination = bookingDetail.Destination;
                            bookingList.Add(booking);
                            preBooking = booking;

                        }


                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return bookingList;
        }
    }
}