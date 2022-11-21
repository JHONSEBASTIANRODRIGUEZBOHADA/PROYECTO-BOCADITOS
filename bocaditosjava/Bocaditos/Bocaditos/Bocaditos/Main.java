package Bocaditos;

import java.util.*;

public class Main {
  public static void main(String[] args) {
    int decision1;
    int decision2;
    Scanner read = new Scanner(System.in);

    Usuario usuario = new Usuario();
    Roles roles = new Roles();
    MateriaPrima materiaPrima = new MateriaPrima();
    Pedido pedido = new Pedido();
    Proveedor proveedor = new Proveedor();
    Orden orden = new Orden();
    Producto producto = new Producto();
    try {
      do {
        System.out.println("¡BIENVENID@ A LA REPOSTERÍA BOCADITOS!\n| 1.- Login | 2.- Registrarse |");
        decision1 = read.nextInt();
        switch (decision1) {
          case 1:
            usuario.Login();
            if (usuario.login == true) {
              do {
                System.out.println("\nBienvenid@ a la repostería Bocaditos.");
                System.out.println("\n¿Donde quiere acceder?");
                System.out.println(
                    "\n1.- Roles\n2.- Usuario\n3.- Orden\n4.- Producto\n5.- Materia Prima\n6.- Pedido\n7.- Proveedor\n8.- Salir");
                decision2 = read.nextInt();
                switch (decision2) {
                  case 1:
                    System.out.println("\n1.- Ingresar Rol\n2.- Consultar Roles\n3.- Eliminar rol");
                    decision2 = read.nextInt();
                    if (decision2 == 1) {
                      roles.Ingresar();
                    } else if (decision2 == 2) {
                      roles.Mostrar();

                    } else if (decision2 == 3) {
                      roles.Eliminar();
                    } else {
                      System.out.println("Dato invalido");
                    }
                    break;

                  case 2:
                    System.out.println("\n1.- Consultar Usuario\n2.- Modificar Usuario");
                    decision2 = read.nextInt();
                    if (decision2 == 1) {
                      usuario.Mostrar();
                    } else if (decision2 == 2) {
                      usuario.Modificar();
                    } else {
                      System.out.println("Dato invalido");
                    }
                    break;
                  case 3:
                    System.out.println(
                        "\n1.- Aprobar oden\n2.- Actualizar Estado\n3.- Actualizar orden\n4.- Pagar orden\n5.- Cancelar orden\n6.- Realizar orden\n7.- Consultar orden");
                    decision2 = read.nextInt();
                    if (decision2 == 1) {
                      orden.aprobarOrden();
                    } else if (decision2 == 2) {
                      orden.actualizarEstadoOrden();
                    } else if (decision2 == 3) {
                      orden.actualizarOrden();
                    } else if (decision2 == 4) {
                      orden.pagarOrden();
                    } else if (decision2 == 5) {
                      orden.cancelarOrden();
                    } else if (decision2 == 6) {
                      orden.realizarOrden();

                    } else if (decision2 == 7) {
                      orden.ConsultarOrden();
                    } else {
                      System.out.println("Dato invalido.");
                    }
                    break;
                  case 4:
                    System.out.println(
                        "\n1.- Consultar Producto\n2.- Realizar Producto \n3.- Cancelar Producto\n4.- Actualizar Producto");
                    decision2 = read.nextInt();
                    if (decision2 == 1) {
                      producto.consultarProducto();
                    } else if (decision2 == 2) {
                      producto.registrarProducto();
                    } else if (decision2 == 3) {
                      producto.eliminarProducto();
                    } else if (decision2 == 4) {
                      producto.actualizarProducto();
                    } else {
                      System.out.println("Dato invalido.");
                    }
                    break;
                  case 5:
                    System.out.println(
                        "\n1.- Ingresar Materia Prima\n2.- Consultar Materia Prima\n3.- Modificar Materia Prima\n4.- Eliminar Materia Prima");
                    decision2 = read.nextInt();
                    if (decision2 == 1) {
                      materiaPrima.IngresarMateriaPrima();
                    } else if (decision2 == 2) {
                      materiaPrima.MostrarMateriaPrima();
                    } else if (decision2 == 3) {
                      materiaPrima.ActualizarMateriaPrima();
                    } else if (decision2 == 4) {
                      materiaPrima.EliminarMateriaPrima();
                    } else {
                      System.out.println("Dato invalido");
                    }
                    break;
                  case 6:
                    System.out.println(
                        "\n1.- Ingresar Pedido\n2.- Consultar Pedido\n3.- Actualizar Pedido\n4.- Cancelar Pedido");
                    decision2 = read.nextInt();
                    if (decision2 == 1) {
                      pedido.IngresarPedido();
                    } else if (decision2 == 2) {
                      pedido.MostrarPedido();
                    } else if (decision2 == 3) {
                      pedido.ActualizarPedido();
                    } else if (decision2 == 4) {
                      pedido.EliminarPedido();
                    } else {
                      System.out.println("Dato invalido.");
                    }
                    break;
                  case 7:
                    System.out.println("\n1.- Registrar Proveedor\n2.- Consultar Proveedor\n3.- Actualizar Proveedor");
                    decision2 = read.nextInt();
                    if (decision2 == 1) {
                      proveedor.registrarProveedor();
                    } else if (decision2 == 2) {
                      proveedor.consultarProveedor();
                    } else if (decision2 == 3) {
                      proveedor.actualizarProveedor();
                    } else {
                      System.out.println("Dato invalido.");
                    }
                    break;
                  case 8:
                    System.out.println("Ha salido del programa.");
                    System.exit(0);
                    break;
                  default:
                    System.out.println("Dato invalido");
                    break;
                }
                System.out.println("¿Quiere volver al Menu?\n1.- Si \n2.- No");
                decision1 = read.nextInt();
              } while (decision1 == 1);
            } else {
              System.out.println("Datos incorrectos.");
            }

            break;

          case 2:
            usuario.Registrar();

            break;
          default:
            break;

        }

        System.out.println("¿Quiere volver al Menu Principal?\n1.- Si \n2.- No");
        decision1 = read.nextInt();
      } while (decision1 == 1);
      System.out.println("Ha salido del programa.");
      read.close();

    } catch (Exception e) {
      System.out.println("Error al ingresar los datos");
    }
  }
}
