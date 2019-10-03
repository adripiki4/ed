package iesserpis.ed;

import java.util.Scanner;

public class HolaMundo {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		String nombre;
		int edad;
		
		System.out.print("Introduzca su nombre: ");
		 nombre = teclado.nextLine();
		System.out.print("hola, "+ nombre);
		System.out.print("Introduzca su edad: ");
		 edad = teclado.nextInt();
			System.out.print("hola, "+ edad);

		 
	}
	

}
