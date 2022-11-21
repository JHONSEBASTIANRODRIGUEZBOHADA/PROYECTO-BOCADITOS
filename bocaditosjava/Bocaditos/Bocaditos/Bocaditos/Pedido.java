package Bocaditos;
import java.util.Scanner;
public class Pedido
{
    private int posicion = 1;
    private int cantidad, actualizar,eliminar;
    int[] pedId = new int[10];
    String[] pedfechaPedido = new String[10];
    String[] pedfechaEntrega = new String[10];
    String[] pedEstado = new String[10];
    
    Scanner Sc = new Scanner(System.in);
       
    public void IngresarPedido()
    {
        try 
        {
        System.out.println("Cuantos registros desea ingresar: ");
        cantidad = Sc.nextInt();
        if(cantidad <=pedId.length)
        {

            for (int i = 1; i < cantidad+1; i++) 
            {
                pedId[i] = posicion;
                
                System.out.println("Ingrese la fecha en la que se realizo el "+ posicion + " pedido");
                pedfechaPedido[i] = Sc.next();Sc.nextLine();
                System.out.println("Ingrese la fecha en la que se entrego el "+ posicion + " pedido");
                pedfechaEntrega[i] = Sc.nextLine();
                System.out.println("Ingrese el Estado del "+ posicion + " pedido");
                pedEstado[i] = Sc.nextLine();
                
                System.out.println("-----------------------------------------------------------------------------");
                posicion ++;         
            }
           
        }
        else
        {
            System.out.println("La cantidad sobrepasa el limite");
        }
                System.out.println("--El registro se realizo con exito--\n");
        } catch (Exception e) {
        System.out.println("Dato ingresado no valido");
        return;
        }  
    }
    public void MostrarPedido()
    { 
     System.out.println("pedId    pedFechaPedido    pedFechaEntrega     pedEstado");
     for (int a = 1; a < pedId.length; a++) 
     {
         System.out.println("-----------------------------------------------------------------------------");
         System.out.println("  "+pedId[a]+"        "+pedfechaPedido[a]+"        "+pedfechaEntrega[a]+"         "+"         "+pedEstado[a]);
     }
    }
    public void ActualizarPedido()
    {

    
        System.out.println("\n¿Desea Actualizar algun dato? \n1 = Si \n2 = No");
        actualizar = Sc.nextInt();
            if(actualizar == 1)
            {
            int opcion;

                System.out.println("\nIngrese el Id del pedido que desea actualizar");
                opcion = Sc.nextInt(); 
                pedId[opcion] = opcion;
                System.out.println("Ingrese la Fecha de realizacion del pedido actualizada");
                pedfechaPedido[opcion] = Sc.next();Sc.nextLine();
                System.out.println("Ingrese la Fecha de Entrega del pedido actualizada");
                pedfechaEntrega[opcion] = Sc.nextLine();
                System.out.println("Ingrese el estado actualizado");
                pedEstado[opcion] = Sc.nextLine();
                System.out.println("\n--Actualización exitosa--\n"); 
            }
    }
    public void EliminarPedido()
    {
            System.out.println("\n¿Desea Eliminar algun dato? \n1 = Si \n2 = No");
            eliminar = Sc.nextInt();
            if(eliminar == 1)
            {
                int opcion;
    
                System.out.println("\nIngrese el Id del pedido que desea eliminar");
                opcion = Sc.nextInt(); 
                pedId[opcion] = 0;
                pedfechaPedido[opcion] = null;
                pedfechaEntrega[opcion] = null;
                pedEstado[opcion] = null;
                System.out.println("\n--El registro se elimino correctamente--\n"); 

            }    
            else
            {
            System.out.println("\n --Fin del programa--");
            }
    }
}
