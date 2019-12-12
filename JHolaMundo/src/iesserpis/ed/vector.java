package iesserpis.ed;

public class vector {

	public static void main(String[] args) {
              
		 
	}
      public static int max(int[] v) {
         int max= v[0];
         for (int i = 1; i < v.length; i++) {
			
        	 if (v[i] > max) {
				max = v[i];
			} 
		}
		return max;
	}    
}