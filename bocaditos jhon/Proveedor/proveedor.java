package Proveedor;
import java.util.*;
public class proveedor {
    private int[] nit = new int[5];
    private String[] nombre = new String[5];
    private String[] direccion = new String[5];
    private int[] telefono = new int[5];
    private String[] correo = new String[5];
    int cantidad;

    Scanner scanner = new Scanner(System.in);

    public void registrarProveedor() 
    {
        System.out.println("\nCuantos proveedores desea igresar");
        cantidad = scanner.nextInt();
        for (int i = 0; i < cantidad; i++) {
            System.out.println("\nIngresar nit del proveedor");
            nit[i] = scanner.nextInt();
            System.out.println("Ingresar el nombre del proveedor");
            nombre[i] = scanner.next();
            System.out.println("Ingresar la direccion del proveedor");
            direccion[i] = scanner.next();
            System.out.println("Ingresar el telefono del proveedor");
            telefono[i] = scanner.nextInt();
            System.out.println("Ingresar el correo del proveedor");
            correo[i] = scanner.next();
        }
    }

    public void actualizarProveedor() 
    {
        

    }

    public void consultarProveedor() 
    {
        System.out.println("|NIT        |        NOMBRE        |        DIRECCION        |        TELEFONO        |        CORREO        |");
        for (int i = 0; i <cantidad; i++) {
            System.out.println("|" + nit[i] + "   |   " + nombre[i] + "   |   " + direccion[i] + "   |   " + telefono[i] + "   |   " + correo[i]+ "|");
        }
    }
}
