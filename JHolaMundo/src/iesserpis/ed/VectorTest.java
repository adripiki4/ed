package iesserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import java.util.Vector;

import org.junit.Test;

class VectorTest {

	@Test
	void indeOf() {
		
		int[] v = {17, 12, 15, 9, 14};
		int x = 15;
		int index = Vector.indexOf(v, x);
	
		assertEquals(2, index);
	}

	public static int indexOf(int[] v, int x) {
		// TODO Auto-generated method stub
		return 0;
	}

}
