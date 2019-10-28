package iesserpis.ed;

class JVector {

	public static void main(String[] args) {

	//	int index = 0;
		//int [] v = {17, 12, 15, 9, 14}; 
		//System.out.println("v [0] = " + v [0]);

		// int index =0;
		 // while (index <5) {
		// System.out.println(index);
		// index++;
		//	}
	
//		for(int index = 0; index <5; index++)
//			System.out.println(index);1
		
		int[] v = new int [] {17, 12, 15, 9, 14} ;
		int x =12;
		int index = indexOf(v, x);
		System.out.println("index= "+ index);
		System.out.println("fin");
		
	}
		public static int indexOf(int[] v, int x)	
		{
			int posicion= -1;
			for(int i=0; i< v.length; i++) 
			{
				if (x == v[i])
				{
					posicion = i;
				}
			}
			return posicion;
		}
}
