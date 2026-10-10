namespace RetoEmpresarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esto realmente no se si lo quiero asi o lo si estaria mejor cambiarlo pero si lo quieres cambiar dale ( es q es mucho texto) 
            Console.WriteLine("=== CLIENTE Y MASCOTA ===");
            Cliente cliente = new Cliente("Luis", "456", 3109876543, "luis@mail.com");
            Mascota m = new Mascota("Firulais", "Perro", "Criollo", 3, 12.5, "Sano");
            cliente.AgregarMascota(m);
            Console.WriteLine("Cliente registrado: Luis");
            Console.WriteLine("Mascota: " + m);

            Veterinario vet = new Veterinario("Ana", "123", 3001234567, "ana@mail.com",
                                              "VET01", "clave123", Especialidad.Cirugia, 2);
            Recepcionista rec = new Recepcionista("Sofía", "789", 3201112233, "sofia@mail.com",
                                                  "REC01", "clave456");
            AuxiliarVeterinario aux = new AuxiliarVeterinario("Pedro", "321", 3151234567, "pedro@mail.com",
                                                              "AUX01", "clave789");
            Administrador admin = new Administrador("Marta", "654", 3009998877, "marta@mail.com",
                                                    "ADM01", "claveAdmin");

            //  INICIO DE SESIÓN 
            Console.WriteLine("\n=== INICIO DE SESIÓN ===");
            InicioSesion login = new InicioSesion();
            Console.WriteLine("Veterinaria con clave correcta: " + login.IngresarEmpleado(vet, "VET01", "clave123"));
            Console.WriteLine("Veterinaria con clave incorrecta: " + login.IngresarEmpleado(vet, "VET01", "otra"));

            //  CITA 
            Console.WriteLine("\n=== CITA ===");
            Consulta general = new ConsultaGeneral(40000, 20);
            Cita cita = rec.RegistrarCitaPresencial(cliente, m, general);
            cita.AsignarVeterinario(vet);
            Console.WriteLine(cita);
            rec.ModificarConsultorio(cita, 5);
            Console.WriteLine("Consultorio del veterinario cambiado a 5");

            cita.AgregarServicio(new ServicioAdicional("Vacuna", 20000));
            Console.WriteLine("Costo (consulta general + vacuna): " + cita.CalcularCosto());

            //  AUXILIAR 
            Console.WriteLine("\n=== AUXILIAR VETERINARIO ===");
            aux.RegistrarSignosVitales(m, 13.0, 38.5);
            aux.PrepararConsultorio(general);
            Insumo vacuna = new Insumo("Vacuna rabia", 10, TipoInsumo.Medicamento);
            aux.GestionarInsumos(vacuna, 5);
            Console.WriteLine("Inventario de vacunas actualizado (+5)");
            Console.WriteLine("Mascota tras el registro: " + m);

            // VETERINARIO
            Console.WriteLine("\n=== VETERINARIO ===");
            Console.WriteLine("¿Está disponible? " + vet.VerificarDisponibilidad());
            vet.RegistrarDiagnostico(m, "Infección leve");
            vet.RegistrarDiagnostico(m, "Desparasitación pendiente");
            Console.WriteLine(vet.PrescribirMedicamento(m, new Medicamento("Amoxicilina", "5 ml", 7)));
            vet.SolicitarExamen(m, "Hemograma");
            vet.ActualizarEstadoSalud(m, "En tratamiento");

            Console.WriteLine("Historial de diagnósticos:");
            foreach (Diagnostico d in vet.ConsultarHistoriaClinica(m).ConsultarHistorial())
            {
                Console.WriteLine(" - " + d);
            }
            Console.WriteLine("Mascota ahora: " + m);

            // ADMINISTRADOR 
            Console.WriteLine("\n=== ADMINISTRADOR ===");
            admin.ModificarCostoConsulta(general, 45000);
            Console.WriteLine("Nuevo costo de la cita: " + cita.CalcularCosto());
            admin.GestionarDescuento(new Descuento("Descuento octubre", 0.10, DateTime.Now, DateTime.Now.AddDays(30)));
            Console.WriteLine("Descuento registrado");
            Reporte rep = admin.GenerarReporte(TipoReporte.Citas, "Octubre 2026");
            rep.Generar();

            //  OTRAS CONSULTAS 
            Console.WriteLine("\n=== OTRAS CONSULTAS ===");
            Consulta espec = new ConsultaEspecializada(80000, 45, Especialidad.Cirugia);
            Consulta urg = new ConsultaUrgencias(50000, 30);
            Console.WriteLine("Especializada: " + espec.CalcularCosto());
            Console.WriteLine("Urgencias: " + urg.CalcularCosto());

            // CANCELAR / FINALIZAR 
            Console.WriteLine("\n=== CANCELAR Y FINALIZAR ===");
            Cita cita2 = rec.RegistrarCitaPresencial(cliente, m, urg);
            Console.WriteLine(cita2);
            rec.CancelarCita(cita2);
            Console.WriteLine(cita2);
            rec.FinalizarAtencion(cita);
            Console.WriteLine(cita);

            Console.ReadLine();
        }
    }
}
