package Documentation;
import java.util.Arrays;

public class BinarySearch {
    /*
        Search algorithm that finds the position of a target value within a SORTED array.
        Half of the array is eliminated during each step.

        Advantages:
            Good for large datasets because we are eliminating half of the elements each turn until we find the element

        Disadvantages:
            Not efficient when working with small datasets.

            Complexity: O(log n)
     */
    public static void main(String args[]){
        /*
        //Using the built-in Arrays binary search function
        int array[] = new int[100];
        int target = 10;

        for(int i = 0; i < array.length; i++){ //filling up the array
            array[i] = i;
        }

        int index = Arrays.binarySearch(array, target);

        if(index == -1){ //target not found
            System.out.println(target + " not found");
        }else{
            System.out.println("Element found at: " + index);
        }
         */
            //Own binary function
            int array[] = new int[100];
            int target = 10;

            for(int i = 0; i < array.length; i++){ //filling up the array
                array[i] = i;
            }

            int index = binarySearch(array, target);

            if(index == -1){ //target not found
                System.out.println(target + " not found");
            }else{
                System.out.println("Element found at: " + index);
            }
        }

    private static int binarySearch(int[] array, int target) {
        int low = 0; //beginning
        int high = array.length - 1; //end

        while(low <= high){
            //middle index
            int middle = low+(high-low)/2;
            int value = array[middle]; //extract the value within the middle

            System.out.println("middle: " + value); //optional, just to see how many steps it takes to find the middle (the target)

            if(value < target){
                low = middle + 1;
            }else if(value > target){
                high = middle - 1;
            }else{
                //We found the target
                return middle;
            }
        }

        return -1; //sentinel value, target not found
    }
}

