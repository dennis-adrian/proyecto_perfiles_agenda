using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna
{
    public class ConcreteDefensaFactory : DefensaFactory
    {
        public override IDefensa GetDefensas(string type)
        {
            switch (type)
            {
                //case "general":
                //    return new DefensaGeneral();
                case "general_tipo":
                    return new DefensaGeneralTipo();
                case "general_estudiante":
                    return new DefensaGeneralEstudiante();
                case "general_tipo_estudiante":
                    return new DefensaGeneralTipoEstudiante();
                case "carrera":
                    return new DefensaCarrera();
                case "carrera_tipo":
                    return new DefensaCarreraTipo();
                case "carrera_estudiante":
                    return new DefensaCarreraEstudiante();
                case "carrera_tipo_estudiante":
                    return new DefensaCarreraTipoEstudiante();
                default:
                    throw new ApplicationException(string.Format("defensa '{0}' cannot be created", type));


            }

        }
        /*
         VehicleFactory factory = new ConcreteVehicleFactory();

 IFactory scooter = factory.GetVehicle("Scooter");
 scooter.Drive(10);

 IFactory bike = factory.GetVehicle("Bike");
 bike.Drive(20);

 Console.ReadKey();*/
    }
}
