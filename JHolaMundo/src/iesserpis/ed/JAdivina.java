package iesserpis.ed;
import java.util.*;
/**
 * 
 * @author adriba
 *
 */
public class JAdivina {

	public static void main(String[] args) {
	//	int contador = 1;
		//
	//	while (contador <= 5) {
	//		System.out.println("contador = " + contador);
		//		contador = contador +1 ; //contador++ ;
				
		
		//	System.out.println("Fin del programa");
			
		// for (int contador = 1; contador <=5; contador++)
			// System.out.println("contador = " + contador);
		 		// System.out.println("Fin del programa");

	Random random = new Random();
	int numeroAleatorio = random.nextInt(1000)+1;
	//System.out.println("numero aleatorio= " + numeroAleatorio);
	
	Scanner teclado = new Scanner(System.in);
	
	int numeroIntroducido;
	int contadorintentos =0;
	int extremoIzquierdo =1;
	int extremoDerecho =1000;
	
		do {
			contadorintentos ++;
		System.out.printf("Adivina el numero de [intento %s] (entre %s y %s): " ,contadorintentos,  extremoIzquierdo , extremoDerecho);
		 numeroIntroducido = teclado.nextInt();
		if (numeroIntroducido < numeroAleatorio)
			extremoIzquierdo = numeroIntroducido +1 ;
		else if (numeroIntroducido > numeroAleatorio)
			extremoDerecho = numeroIntroducido -1;
	} while (numeroIntroducido != numeroAleatorio);
	 
	System.out.println("Enhorabuena has acertado");
	
	
	
	
	}
		
		
		
		

	}


