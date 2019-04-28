package sample;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent root = FXMLLoader.load(getClass().getResource("realSample.fxml"));
        primaryStage.setTitle("Travel Experts");
        primaryStage.setScene(new Scene(root, 600, 562));
        primaryStage.show();
    }


    public static void main(String[] args) {
        launch(args);
    }
}
