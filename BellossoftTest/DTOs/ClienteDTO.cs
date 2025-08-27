using BellosoftTest.DTOs;

namespace BellosoftTest.DTOs
{
    public class ClienteDTO
    {
        public string Nome { get; set; }
        public List<ContatoDTO> Contatos { get; set; }
        public List<EnderecoDTO> Enderecos { get; set; }
    }
}
