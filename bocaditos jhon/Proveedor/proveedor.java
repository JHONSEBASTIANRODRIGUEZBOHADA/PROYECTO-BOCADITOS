package Proveedor;
import java.util.*;
public class proveedor {
    private int cantidad;
    private int provid;
    private int actualizar;
    private int[] id = {1};
    private int[] nit = {1026453722};
    private String[] nombre = {"Oscar"};
    private String[] direccion = {"cr46 b N°21 bsur"};
    private long[] telefono = {314425679};
    private String[] correo = {"Oscar1031@gmail.com"};
    

    Scanner scanner = new Scanner(System.in);

    public void registrarProveedor() 
    {
        System.out.println("\n¿Cuantos proveedores desea igresar?");
        cantidad = scanner.nextInt();
        if (cantidad > 0) 
        {
            for (int i = 0; i < cantidad; i++) {
                System.out.println("\nIngrese el nit del "+(i+1)+ " proveedor");
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
        }
        else
            {
                System.out.println("No ingreso un valor correcto");
            } 
        System.out.println("------REGISTRO EXITOSO------");
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
        for (int i = 0; i <nombre.length; i++) {
            System.out.println("\nID: " + id[i] + "\nNIT: " + nit[i] + "\nNOMBRE: " + nombre[i] + "\nDIRECCION: " + direccion[i] + "\nTELEFONO: " + telefono[i] + "\nCORREO: " + correo[i]);
        }
        for (int j = 1; j <cantidad; j++) {
            System.out.println("\nID: " + id[j+2] + "\nNIT: " + nit[j] + "\nNOMBRE: " + nombre[j] + "\nDIRECCION: " + direccion[j] + "\nTELEFONO: " + telefono[j] + "\nCORREO: " + correo[j]);
        }
        
    }
}
