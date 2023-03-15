import java.io.File;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) throws Exception
    {

        Scanner sc = new Scanner(new File("./lego_db/colors.csv"));
        sc.useDelimiter(",");
        while(sc.hasNext()){
            System.out.println(sc.next());
        }
        sc.close();
    }
}
