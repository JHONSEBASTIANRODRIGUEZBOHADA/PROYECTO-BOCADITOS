package Proveedor;
import java.util.*;

public class main {

    public static void main(String[] args) 
    {
        int opcion;
        Scanner scanner = new Scanner(System.in);
        proveedor proveedor = new proveedor();

        System.out.println("\nSECCION PROVEEDOR");
        do
        {
            System.out.println("\nseleccione la opcion que desea realizar \n1.Registrar proveedor \n2.Actualizar proveedor \n3.Consultar Proveedor");
            opcion = scanner.nextInt();

            switch(opcion)
            {
                case 1:
                    proveedor.registrarProveedor();
                break;

                case 2:
                    proveedor.actualizarProveedor();
                break;

                case 3:
                    proveedor.consultarProveedor();
                break;

                default:
                    System.out.println("No ingreso un valor correcto");
                break;
            }
            System.out.println("\nDesea realizar otra accion \n0.Si \n1.No");
            opcion = scanner.nextInt();
            
        }while(opcion == 0);
        scanner.close();
    }
}
