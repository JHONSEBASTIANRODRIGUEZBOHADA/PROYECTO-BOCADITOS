package Bocaditos;

import java.util.*;

public class Producto {
  Scanner sc = new Scanner(System.in);

  int prod, codigoProducto, idProducto, cantidad, productos;
  int[] codProducto = { 1, 2, 3, 4 };
  String[] Producto = { "1-Pastel", "2-Cupcake", "3-Gelatina", "4-Galletas" };
  String[] Producto1 = { "1-Pastel" };
  String[] Producto2 = { "2-Cupcake" };
  String[] Producto3 = { "3-Gelatina" };
  String[] Producto4 = { "4-Galletas" };
  String[] Producto10 = { "1-Pastel de mora", "2-Pastel de fresa" };
  String[] Producto20 = { "1-Cupcake de mora", "2-Cupcake de fresa" };
  String[] Producto30 = { "1-Gelatina de mora", "2-Gelatina de fresa" };
  String[] Producto40 = { "1-Galleta de vainilla", "2-Galleta de chocolate" };

  public void registrarProducto() {
    try {
      do {
        System.out.println("Porfavor digite el codigo del producto que desea registrar: ");
        for (int i = 0; i < codProducto.length; i++) {
          System.out.println(Producto[i]);
        }
        prod = sc.nextInt();
        switch (prod) {

          case 1:
            for (int i = 0; i < Producto1.length; i++) {
              System.out.println("\nIngrese la cantidad del producto seleccionado que va a registrar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("\nLa cantidad de pasteles registrados fuerón: " + cantidad);

            }

            break;
          case 2:
            for (int i = 0; i < Producto2.length; i++) {
              System.out.println("Ingrese la cantidad del producto seleccionado que va a registrar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("\nLa cantidad de cupcakes registrados fueron: " + cantidad);
            }

            break;
          case 3:
            for (int i = 0; i < Producto3.length; i++) {
              System.out.println("Ingrese la cantidad del producto seleccionado que va a registrar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("La cantidad de gelatinas registradas fueron: " + cantidad);
            }

            break;
          case 4:
            for (int i = 0; i < Producto4.length; i++) {
              System.out.println("Ingrese la cantidad del producto seleccionado que va a registrar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("La cantidad de galletas registradas fueron: " + cantidad);
            }
            break;
        }

        System.out.println("\n¿Quiere registrar otro producto?\n1-Si\n2-No");
        prod = sc.nextInt();
      } while (prod == 1);

    } catch (Exception e) {
      System.out.println("\nNo se pudo registrar el producto.");
    }

  }

  public void consultarProducto() {
    try {
      do {
        System.out.println("Porfavor digite el codigo del producto que desea consultar ");
        for (int i = 0; i < codProducto.length; i++) {
          System.out.println(Producto[i]);
        }
        productos = sc.nextInt();
        switch (productos) {
          case 1:
            System.out.println("El producto que usted seleccionó contiene: ");
            for (int i = 0; i < codProducto.length; i++) {
              System.out.println(Producto10[i]);
            }

            break;
          case 2:
            System.out.println("El producto que usted seleccionó contiene: ");
            for (int i = 0; i < codProducto.length; i++) {
              System.out.println(Producto20[i]);
            }
            break;
          case 3:
            System.out.println("El producto que usted seleccionó contiene: ");
            for (int i = 0; i < codProducto.length; i++) {
              System.out.println(Producto30[i]);
            }
            break;
          case 4:
            System.out.println("El producto que usted seleccionó contiene: ");
            for (int i = 0; i < codProducto.length; i++) {
              System.out.println(Producto40[i]);
            }
            break;

        }

        System.out.println("¿Quiere consultar otro producto?\n1-Si\n2-No");
        prod = sc.nextInt();
      } while (prod == 1);

    } catch (Exception e) {
      System.out.println("No se pudo consultar el producto");
    }

  }

  public void actualizarProducto() {
    try {
      do {
        System.out.println("Porfavor digite el codigo del producto que desea actualizar: ");
        for (int i = 0; i < codProducto.length; i++) {
          System.out.println(Producto[i]);
        }
        prod = sc.nextInt();
        switch (prod) {

          case 1:
            for (int i = 0; i < Producto1.length; i++) {
              System.out.println("\nIngrese la cantidad del producto seleccionado que va a actualizar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("\nLa cantidad de pasteles actualizados fuerón: " + cantidad);

            }

            break;
          case 2:
            for (int i = 0; i < Producto2.length; i++) {
              System.out.println("Ingrese la cantidad del producto seleccionado que va a actualizar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("\nLa cantidad de cupcakes actualizados fueron: " + cantidad);
            }

            break;
          case 3:
            for (int i = 0; i < Producto3.length; i++) {
              System.out.println("Ingrese la cantidad del producto seleccionado que va a actualizar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("La cantidad de gelatinas actualizadas fueron: " + cantidad);
            }

            break;
          case 4:
            for (int i = 0; i < Producto4.length; i++) {
              System.out.println("Ingrese la cantidad del producto seleccionado que va a actualizar:  " + (i + 1));
              cantidad = sc.nextInt();

              System.out.println("La cantidad de galletas actualizados fueron: " + cantidad);
            }
            break;
        }

        System.out.println("\n¿Quiere quiere actualizar otro producto?\n1-Si\n2-No");
        prod = sc.nextInt();
      } while (prod == 1);

    } catch (Exception e) {
      System.out.println("\nNo se pudo actualizar el producto.");
    }

  }

  public void eliminarProducto() {
    try {
      System.out.println("¿Desea eliminar algun producto?\n1-Si\n2-No");
      prod = sc.nextInt();
      switch (prod) {
        case 1:
          do {
            System.out.println(
                "\nEscriba el codigo del producto que desea eliminar: \n1-Pastel\n2-Cupcake\n3-Gelatina\n4-Otros");
            codigoProducto = sc.nextInt();
            idProducto = (codigoProducto - 1);
            Producto1[idProducto] = null;
            Producto2[idProducto] = null;
            Producto3[idProducto] = null;
            Producto4[idProducto] = null;

            System.out.println("\nEl producto seleccionado de la lista ha sido borrado de manera exitosa");

            System.out.println("\n¿Desea eliminar otro producto?\n1-Si\n2-No");
            prod = sc.nextInt();
          } while (prod == 1);
        case 2: {
          System.out.println("\nNo se eliminará ningun producto");
        }
      }
    } catch (Exception e) {
      System.out.println("\nNo se pudo eliminar ningun producto");
    }
  }

  public static void main(String[] args) {
    Producto pro = new Producto();
    pro.registrarProducto();
    pro.consultarProducto();
  }
}
