package Documentation;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Gui {
    public static void main(String[] args){
        JFrame frame = new JFrame(); //creating new instance of JFrame, this is like the window

        JButton button = new JButton("Click me!"); //creating a button with the label test
        button.setBounds(130,100,100,40); //setting the position on the frame of the button x axis, y axis, width, height

        JTextField txtField = new JTextField(); //creating a text field (paragraph)
        txtField.setText(""); //empty string at the beginning before pressing the button
        txtField.setBounds(130,160,100,40);

        frame.add(button); //adding the button to the frame
        frame.add(txtField); //adding the txtField to the frame


        frame.setSize(400,500); //setting the size of the frame width and height
        frame.setLayout(null); //using no layout managers
        frame.setVisible(true); //making the frame visible

        //Wait for the pressing action to be performed
        button.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(button.getModel().isArmed()){ //testing if the button is pressed to display a text
                    txtField.setText("I am pressed !"); //text appears in the frame once the button is clicked
                    //System.out.println("I am pressed !");
                }
            }
        });
    }
}
