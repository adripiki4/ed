package iesserpis.ed;

import static org.junit.Assert.*;

import java.util.Vector;

import org.junit.Test;

public class VectorTestTest {

	@Test
		void indexOf() {
		
		int[] v = {17, 12, 15, 9, 14};
		
		assertEquals(0, Vector.indexOf(v,15));
		assertEquals(2, Vector.indexOf(v, 15));
		
		
	}

}
