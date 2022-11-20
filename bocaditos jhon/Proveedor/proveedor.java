package Proveedor;
import java.util.*;
public class proveedor {
    private int cantidad;
    private int provid;
    private int actualizar;
    private int[] id = new int[5];
    private int[] nit = new int[5];
    private String[] nombre = new String[5];
    private String[] direccion = new String[5];
    private long[] telefono = new long[5];
    private String[] correo = new String[5];
    

    Scanner scanner = new Scanner(System.in);

    public void registrarProveedor() 
    {
        System.out.println("\n¿Cuantos proveedores desea igresar?");
        cantidad = scanner.nextInt();
        if (cantidad > 0) 
        {
            for (int i = 0; i < cantidad; i++) {
                System.out.println("\nIngrese el nit del "+ (i+1) + " proveedor");
                nit[i] = scanner.nextInt();
                System.out.println("Ingrese el nombre del proveedor");
                nombre[i] = scanner.next();
                System.out.println("Ingrese la direccion del proveedor");
                direccion[i] = scanner.next();
                System.out.println("Ingrese el telefono del proveedor");
                telefono[i] = scanner.nextLong();
                System.out.println("Ingrese el correo del proveedor");
                correo[i] = scanner.next();
            } 
            System.out.println("------REGISTRO EXITOSO------");  
        }
    }

    public void actualizarProveedor() 
    {
        System.out.println("Ingrese el ID del proveedor a actualizar");
        cantidad = scanner.nextInt();
        provid = (cantidad - 1);
        System.out.println("\nSeleccione lo que desea actualizar \n1.Actualizar direccion \n2.Actualizar telefono \n3.Actualizar Correo");
        actualizar = scanner.nextInt();
        switch (actualizar) 
        {
            case 1:
                System.out.println("\nIngrese la nueva direccion:");
                direccion[provid] = scanner.next();
            break;
            case 2:
                System.out.println("\nIngrese el nuevo telefono:");
                telefono[provid] = scanner.nextLong();
            break;
            case 3:
                System.out.println("\nIngrese el nuevo correo:");
                correo[provid] = scanner.next();
            break;

            default:
                System.out.println("No ingreso un valor valido.");
            break;
        }
    }

    public void consultarProveedor() 
    {
        for (int j = 0; j <cantidad; j++) {
            System.out.println("\nID: " + id[j+1] + "\nNIT: " + nit[j] + "\nNOMBRE: " + nombre[j] + "\nDIRECCION: " + direccion[j] + "\nTELEFONO: " + telefono[j] + "\nCORREO: " + correo[j]);
        }
        
    }
}
