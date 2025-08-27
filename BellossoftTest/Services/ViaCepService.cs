using BellosoftTest.DTOs;

namespace BellosoftTest.Services
{
    public class ViaCepService
    {
        private readonly HttpClient _httpClient;

        public ViaCepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ViaCepResponse?> BuscarEnderecoPorCep(string cep)
        {
            var url = $"https://viacep.com.br/ws/{cep}/json/";
            var response = await _httpClient.GetFromJsonAsync<ViaCepResponse>(url);

            if (response == null || response.Cep == null)
                return null;

            return response;
        }

    }
}