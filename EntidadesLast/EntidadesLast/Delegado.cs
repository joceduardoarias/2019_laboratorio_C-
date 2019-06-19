using EntidadesLast;
//PASO 1
public delegate void DelegadoSueldo(Empleado empleado,float f);//con este delegado vamos a generar un evento

public delegate void DelSueldo(EmpleadoMejorado EmpleadoMejorado, EmpleadoSueldoArg sueldoArg);

public enum TipoManejador
{
    LimiteSueldo,
    Log,
    Ambos
}