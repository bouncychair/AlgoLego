package SearchAlgo;

import com.opencsv.CSVReader;
import com.opencsv.CSVReaderBuilder;

import java.io.FileReader;
import java.util.ArrayList;
import java.util.Objects;

public class colorsBinary {
    public static void main(String[] args) throws Exception {
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

            int foundIndex = binarySearch(colors, "237841");
            if (foundIndex != -1) { //if the index is found (so the index it is not -1) then we have found the value
                System.out.println("Element found at index " + foundIndex);
            } else {
                System.out.println("Element not found");
            }
        }
    }

    private static int binarySearch(ArrayList<String> colors, String c) {
        int l = 0; //low
        int h = colors.size() - 1; //high
        int m; //middle

        while(l <= h){
            m = (l+h)/2;

            if(colors.get(m).compareTo(c) < 0){
                l = m+1;
            }else if(colors.get(m).compareTo(c) > 0){
                h = m -1;
            }else{
                return m;
            }

        }



        return -1;
    }
}
