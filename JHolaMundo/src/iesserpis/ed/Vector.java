package iesserpis.ed;
import java.util.*;
public class Vector {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
	}
	public static int max(int[] v) {
		int max = v [0];
		for ( int index =1; index < v.length; index++) {
			if (v[index]> max) 
				max = v [index];
						
		}
		return max;
	}
	public static int[] selectionSort(int[] v1) {
		for(int i=0;i< v1.length ;i++) {
            for(int j=i+1;j<v1.length;j++){
                if(v1[i]>v1[j]){
                    //Intercambiamos valores
                    int variableauxiliar=v1[i];
                    v1[i]=v1[j];
                    v1[j]=variableauxiliar;
                }
               }
            }
		return v1;
	}
}