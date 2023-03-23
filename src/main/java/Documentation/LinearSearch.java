package Documentation;

public class LinearSearch {
    //linear search = Iterate through a collection ONE ELEMENT AT A TIME
    //complexity: O(n)
    /*
        Advantages:
            Fast for searches of small to medium data sets
            Does not need to be sorted
            Useful for data structures that do not have random access (Linked List)

        Disadvantage:
            Slow for large data sets
     */

    public static void main(String args[]){
        int[] array = {9,1,8,2,7,3,6,4,5};

        int index = linearSearch(array,1); //second parameter is the value being searched for

        if(index != -1){ //if the index is found (so the index it is not -1) then we have found the value
            System.out.println("Element found at index " + index);
        }else{
            System.out.println("Element not found");
        }
    }

    private static int linearSearch(int[] array, int value) {
        for(int i = 0; i < array.length; i++){ //start from 0 and run as long as the array lasts incrementing
            if(array[i] == value){ //if the array value (i is the index) equals to our value
                return i; //return the index
            }
        }


        return -1; //sentinel value if it doesn't find the value, otherwise return this
    }
}
