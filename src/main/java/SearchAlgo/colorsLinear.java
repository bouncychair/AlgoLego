package SearchAlgo;
import com.opencsv.CSVReader;
import com.opencsv.CSVReaderBuilder;
import com.opencsv.enums.CSVReaderNullFieldIndicator;
import com.opencsv.exceptions.CsvValidationException;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Objects;
import java.util.Scanner;

//./lego_db/colors.csv
public class colorsLinear {
    public static void main(String[] args) throws Exception{
        ArrayList<String> colors = new ArrayList<String>();
        try {
            //csv file containing data
            String strFile = "./lego_db/colors.csv";
            CSVReader reader = new CSVReaderBuilder(new FileReader(strFile)).withSkipLines(1).build();
            String[] nextLine;
            int lineNumber = 0;
            while ((nextLine = reader.readNext()) != null) {
                // nextLine[] is an array of values from the line
                colors.add(nextLine[2]);
                //System.out.println(nextLine[2]);
            }
        } finally {
            //System.out.println(colors);

            int foundIndex = linearSearch(colors, "237841");
            if(foundIndex != -1){ //if the index is found (so the index it is not -1) then we have found the value
                System.out.println("Element found at index " + foundIndex);
            }else{
                System.out.println("Element not found");
            }
        }
    }

    private static int linearSearch(ArrayList<String> colors, String c){
        for(int i=0; i < colors.size(); i++){
            if(Objects.equals(colors.get(i), c)){ //this is not correct
                return i;
            }
        }

        return -1;
    }
}


