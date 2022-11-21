package Bocaditos;

import java.util.Scanner;

public class MateriaPrima {
  private int posicion = 1;
  private int cantidad, actualizar, eliminar;
  int[] matId = new int[10];
  double[] matPrecio = new double[10];
  String[] matNombre = new String[10];
  String[] matEstado = new String[10];
  int[] matCantidad = new int[10];

  Scanner Sc = new Scanner(System.in);

  public void IngresarMateriaPrima() {
    try {
      System.out.println("Cuantos registros desea ingresar: ");
      cantidad = Sc.nextInt();
      if (cantidad <= matId.length) {

        for (int i = 1; i < cantidad + 1; i++) {
          matId[i] = posicion;

          System.out.println("Ingrese el precio de la " + posicion + " materia prima");
          matPrecio[i] = Sc.nextDouble();
          Sc.nextLine();
          System.out.println("Ingrese el Nombre de la " + posicion + " materia prima");
          matNombre[i] = Sc.nextLine();
          System.out.println("Ingrese la Cantidad de la " + posicion + " materia prima");
          matCantidad[i] = Sc.nextInt();
          Sc.nextLine();
          System.out.println("Ingrese el Estado de la " + posicion + " materia prima");
          matEstado[i] = Sc.nextLine();
          System.out.println("-----------------------------------------------------------------------------");
          posicion++;
        }

      } else {
        System.out.println("La cantidad sobrepasa el limite");
      }
      System.out.println("--El registro se realizo con exito--\n");
    } catch (Exception e) {
      System.out.println("Dato ingresado no valido");
      return;
    }
  }

  public void MostrarMateriaPrima() {
    System.out.println("matId    matPrecio    matNombre    matCantidad    matEstado");
    for (int a = 1; a < matId.length; a++) {
      System.out.println("-------------------------------------------------------------------------------------------");
      System.out.println(
          "  " + matId[a] + "        " + matPrecio[a] + "        " + matNombre[a] + "         " + matCantidad[a]
              + "         " + matEstado[a]);
    }
  }

  public void ActualizarMateriaPrima() {

    System.out.println("\n¿Desea Actualizar algun dato? \n1 = Si \n2 = No");
    actualizar = Sc.nextInt();
    if (actualizar == 1) {
      int opcion;

      System.out.println("\nIngrese el Id de la materia prima que desea actualizar");
      opcion = Sc.nextInt();
      matId[opcion] = opcion;
      System.out.println("Ingrese el precio actualizado");
      matPrecio[opcion] = Sc.nextDouble();
      Sc.nextLine();
      System.out.println("Ingrese el nuevo nombre actualizado");
      matNombre[opcion] = Sc.nextLine();
      System.out.println("Ingrese la cantidad actualizada");
      matCantidad[opcion] = Sc.nextInt();
      Sc.nextLine();
      System.out.println("Ingrese el estado actualizado");
      matEstado[opcion] = Sc.nextLine();
      System.out.println("\n--Actualización exitosa--\n");
    }
  }

  public void EliminarMateriaPrima() {
    System.out.println("\n¿Desea Eliminar algun dato? \n1 = Si \n2 = No");
    eliminar = Sc.nextInt();
    if (eliminar == 1) {
      int opcion;

      System.out.println("\nIngrese el Id de la materia prima que desea eliminar");
      opcion = Sc.nextInt();
      matId[opcion] = 0;
      matPrecio[opcion] = 0;
      matCantidad[opcion] = 0;
      matNombre[opcion] = null;
      matEstado[opcion] = null;
      System.out.println("\n--El registro se elimino correctamente--\n");

    } else {
      System.out.println("\n --Fin del programa--");
    }
  }
}
