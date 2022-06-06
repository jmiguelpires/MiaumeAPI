using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiaumeAPI.Models
{
    public class UsuarioPet
    {
        [Key]
        public long idPet { get; set; }

        public virtual Usuario Usuario { get; set; }
        [ForeignKey("Usuario")]
        public long CPFCNPJ { get; set; }

        public string tipoPet { get; set; }
        public string nmPet { get; set; }
        public DateTime dtNascimento { get; set; }
        public string sexo { get; set; }
        public string raca { get; set; }
        public string porte { get; set; }
        public decimal pesokg { get; set; }
        public bool inVacinado { get; set; }
        public bool inVermifugado { get; set; }
        public bool inPedigree { get; set; }
        public bool inCuidadoEspecial { get; set; }
        public bool inPersonalidadeDocil { get; set; }
        public bool inPersonalidadeTranquilo { get; set; }
        public bool inPersonalidadeAlerta { get; set; }
        public bool inPersonalidadeAgressivo { get; set; }
        public bool inPersonalidadeAtivoMinimo { get; set; }
        public bool inPersonalidadeAtivoMedio { get; set; }
        public bool inPersonalidadeAtivoMaximo { get; set; }
        public bool inPersonalidadeCarinhoso { get; set; }
        public bool inPersonalidadeAssustado { get; set; }
        public bool inPersonalidadePreguicoso { get; set; }
        public bool inPersonalidadeExplorador { get; set; }        
        public bool inPersonalidadeCurioso { get; set; }        
        public bool inPersonalidadeMedroso { get; set; }
        public string ImgPet1 { get; set; }
        public string ImgPet2 { get; set; }
        public string ImgPet3 { get; set; }
        public string ImgPet4 { get; set; }
        public string txDescricao { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime? dtAdotado { get; set; }



    }
}
