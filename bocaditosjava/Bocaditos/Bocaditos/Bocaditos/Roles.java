package Bocaditos;

import java.util.*;

public class Roles {
  int[] rolId = { 1, 2, 3, 4 };
  String[] rolDescripcion = { "Administrador", "Cliente", "Repostero", "Domiciliario" };
  int cantidad, eliminar, rolEliminar, seleccion;
  Scanner read = new Scanner(System.in);

  public void Ingresar() {
    try {
      System.out.println("¿Cuantos roles desea ingresar?");
      cantidad = read.nextInt();
      if (cantidad <= rolId.length) {
        for (int i = 0; i < cantidad; i++) {
          System.out.println("Ingrese la descripción del rol " + (i + 1));
          rolDescripcion[i] = read.next();
          rolId[i] = (i + 1);
        }
      } else {
        System.out.println("Cantidad de roles a ingresar invalida");
      }
    } catch (Exception e) {
      System.out.println("Error. Dato invalido.");
    }

  }

  public void Mostrar() {
    System.out.println("\nLos roles actuales son:");
    for (int i = 0; i < rolId.length; i++)
      System.out.println("ID: " + rolId[i] + " - Descripción: " + rolDescripcion[i]);
  }

  public void Eliminar() {
    try {

      do {
        System.out.println("\nEscriba el ID del rol a eliminar: ");
        rolEliminar = read.nextInt();
        int ID = (rolEliminar - 1);
        rolId[ID] = 0;
        rolDescripcion[ID] = null;
        System.out.println("\nEl rol " + rolEliminar + " Ha sido borrado de manera exitosa");

        System.out.println("\n¿Desea eliminar otro rol?\n1.-Si\n2.-No");
        eliminar = read.nextInt();
      } while (eliminar == 1);

    } catch (Exception e) {
      System.out.println("Error. Dato invalido.");
    }
  }

}
