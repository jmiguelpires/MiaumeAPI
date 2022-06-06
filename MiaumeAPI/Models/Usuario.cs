using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiaumeAPI.Models
{
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CPFCNPJ { get; set; }
        public virtual ICollection<UsuarioPet> UsuarioPets { get; set; }
        public string nmUsuario { get; set; }
        public DateTime dtNascimento { get; set; }
        public string imgFotoPerfil { get; set; }
        public bool inPessoaFisica { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
#nullable enable
        public string? sexo { get; set; }
#nullable disable
        public string telefone { get; set; }
        public string cdEstado { get; set; }
        public string cidade { get; set; }

    }
}
