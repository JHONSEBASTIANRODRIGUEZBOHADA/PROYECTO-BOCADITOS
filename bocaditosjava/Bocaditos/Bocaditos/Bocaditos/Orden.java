package Bocaditos;

import java.util.*;

public class Orden {
  Scanner sc = new Scanner(System.in);
  int orden, numOrden, idSeleccionado, seleccioID, ordenRea, RealizarOrd;

  int[] Orden = { 1, 2, 3, 4, 5, 6 };
  int[] OrdenReal = { 1, 2, 3 };
  String[] EstadoOR = { "Creada", "Creada", "En proceso" };
  int[] CanOrden = { 1, 2, 3 };
  String[] Estado = { "Creada", "Creada", "Creada", "Creada", "Creada", "Creada" };
  String[] EstadoM = { "Entregada", "En proceso", "Entregada", "En camino", "Entregada", "Cancelada" };
  String[] OrdProductos = { "Torta", "Cupcake", "Gelatina", "Chocolates" };
  int[] CantProductos = { 1, 2, 3, 4 };
  int pregunta, tarjeta, cvv, documento;
  String estado;

  public void aprobarOrden() {
    try {

      do {
        System.out.println(
            "Porfavor digite la orden que desea aprobar de acuerdo a las siguientes ordenes en la lista:");
        for (int i = 0; i < Orden.length; i++) {
          System.out.println(Orden[i] + " - " + Estado[i]);
        }
        numOrden = sc.nextInt();
        System.out.println("El estado actual de la orden " + Orden[(numOrden - 1)] + " es: " + Estado[(numOrden - 1)]);
        System.out.println("¿Desea aprobarla?:\n1.- Si\n2.- No");
        pregunta = sc.nextInt();
        if (pregunta == 1) {
          Estado[(numOrden - 1)] = "Aprobada";
          System.out.println("Se aprobó la orden: " + Orden[(numOrden - 1)]);
        } else if (pregunta == 2) {
          Estado[(numOrden - 1)] = "Cancelada";
          System.out.println("Se canceló la orden: " + Orden[(numOrden - 1)]);
        } else {
          System.out.println("Respuesta invalida.");
        }

        System.out.println("¿Desea revisar otra orden para actualizar?\n1.-Si\n2.-No");
        orden = sc.nextInt();
      } while (orden == 1);

    } catch (Exception e) {
      System.out.println("\nDato invalido, No se pudo aprobar la orden.");
    }
  }

  public void actualizarEstadoOrden() {
    try {
      do {
        System.out.println(
            "Porfavor digite la orden que desea actualizar de acuerdo a las siguientes ordenes en la lista:");
        for (int i = 0; i < Orden.length; i++) {
          System.out.println(Orden[i] + " - " + EstadoM[i]);
        }
        numOrden = sc.nextInt();
        sc.nextLine();
        System.out.println("El estado actual de la orden " + Orden[(numOrden - 1)] + " es: " + EstadoM[(numOrden - 1)]);
        System.out.println("Ingrese el nuevo estado de la orden");
        estado = sc.nextLine();
        EstadoM[(numOrden - 1)] = estado;
        System.out
            .println("Se actualizo el estado de la orden " + Orden[(numOrden - 1)] + " es: " + EstadoM[(numOrden - 1)]);

        System.out.println("¿Desea revisar otra orden para actualizar?\n1.-Si\n2.-No");
        orden = sc.nextInt();
      } while (orden == 1);

    } catch (Exception e) {
      System.out.println("\nDato invalido, No se puede actualizar el estado de la orden.");
    }

  }

  public void actualizarOrden() {
    try {
      System.out.println(
          "Porfavor digite la orden que desea actualizar de acuerdo a las siguientes ordenes en la lista:");
      for (int i = 0; i < OrdenReal.length; i++) {
        System.out.println(OrdenReal[i]);
      }
      numOrden = sc.nextInt();
      System.out.println("La orden " + OrdenReal[(numOrden - 1)] + "Contiene: ");
      for (int i = 0; i < OrdProductos.length; i++) {
        System.out.println(CantProductos[i] + " - " + OrdProductos[i]);
      }
      System.out.println("¿Cual desea eliminar?");
      numOrden = sc.nextInt();
      if (numOrden == 1) {
        OrdProductos[0] = null;
        System.out.println("Se actualizo la orden.");
      } else if (numOrden == 2) {
        OrdProductos[1] = null;
        System.out.println("Se actualizo la orden.");
      } else if (numOrden == 3) {
        OrdProductos[2] = null;
        System.out.println("Se actualizo la orden.");
      } else if (numOrden == 4) {
        OrdProductos[3] = null;
        System.out.println("Se actualizo la orden.");
      } else {
        System.out.println("error.");
      }

    } catch (Exception e) {
      System.out.println("\nDato invalido. No se puede actualizar la orden.");
    }

  }

  public void pagarOrden() {
    try {
      System.out.println(
          "Porfavor digite la orden que desea pagar de acuerdo a las siguientes ordenes en la lista:");
      for (int i = 0; i < OrdenReal.length; i++) {
        System.out.println(OrdenReal[i]);
      }
      numOrden = sc.nextInt();
      System.out.println("Por favor introduzca el numero de tarjeta");
      tarjeta = sc.nextInt();
      System.out.println("Por favor introduzca el numero CVV");
      cvv = sc.nextInt();
      System.out.println("Por favor introduzca el numero de documento del titular de la tarjeta");
      documento = sc.nextInt();

      System.out.println(
          "La orden " + numOrden + " se pagó exitosamente.");
    } catch (Exception e) {
      System.out.println("\nNo se pudo pagar la orden.");
    }
  }

  public void cancelarOrden() {
    try {
      System.out.println("¿Desea cancelar la orden que está en curso?\n1-Si\n2-No ");
      ordenRea = sc.nextInt();

      switch (ordenRea) {
        case 1:
          do {
            System.out.println("Porfavor seleccione la orden que desea cancelar: ");
            for (int i = 0; i < OrdenReal.length; i++) {
              System.out.println(OrdenReal[i] + " - " + EstadoOR[i]);
            }
            numOrden = sc.nextInt();
            EstadoOR[(numOrden - 1)] = "Cancelada";
            System.out.println("Se ha cancelado la orden " + numOrden + " correctamente.");

            System.out.println("¿Tiene otra orden en curso que desea cancelar?\n1.-Si\n2.-No");
            orden = sc.nextInt();
          } while (orden == 1);
        case 2: {
          System.out.println(
              "\nNo se realizara ninguna otra modificacion en las ordenes");
        }
      }

    } catch (Exception e) {
      System.out.println("\nNo se pudo cancelar la orden.");
    }
  }

  public void realizarOrden() {
    try {

      System.out.println("Seleccione el producto que desea ordenar:  ");
      for (int i = 0; i < OrdProductos.length; i++) {
        System.out.println(CantProductos[i] + " - " + OrdProductos[i]);
      }
      numOrden = sc.nextInt();

      System.out.println("Se realizo una orden de: " + OrdProductos[(numOrden - 1)]);

    } catch (

    Exception e) {
      System.out.println("No se pudo realizar la orden.");
    }

  }

  public void ConsultarOrden() {
    System.out.println("Las ordenes actuales son:");
    for (int i = 0; i < Orden.length; i++)
      System.out.println(Orden[i] + " - " + EstadoM[i]);
  }
}
