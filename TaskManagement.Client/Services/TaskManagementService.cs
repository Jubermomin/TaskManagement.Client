using EmployeeManagement.Shared.Models;
using System.Net.Http.Json;
using TaskManagement.Client;

namespace TaskManagement.Client.Services
{
    public class TaskManagementService
    {
        private readonly HttpClient _httpClient;

        public TaskManagementService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public async Task<IEnumerable<EmployeeTask>> GetTasksAsync()
        //{
        //    return await _httpClient.GetFromJsonAsync<EmployeeTask[]>("api/tasks");
        //}

        //public async Task<EmployeeTask> GetTaskAsync(int id)
        //{
        //    return await _httpClient.GetFromJsonAsync<EmployeeTask>($"api/tasks/{id}");
        //}

        //public async Task CreateTaskAsync(EmployeeTask task)
        //{
        //    await _httpClient.PostAsJsonAsync("api/tasks", task);
        //}

        //public async Task UpdateTaskAsync(EmployeeTask task)
        //{
        //    await _httpClient.PutAsJsonAsync($"api/tasks/{task.TaskId}", task);
        //}

        //public async Task DeleteTaskAsync(int id)
        //{
        //    await _httpClient.DeleteAsync($"api/tasks/{id}");
        //}
        //public async Task AddDocumentAsync(int taskId, Document document)
        //{
        //    await _httpClient.PostAsJsonAsync($"api/tasks/{taskId}/documents", document);
        //}

        //public async Task<IEnumerable<Document>> GetDocumentsAsync(int taskId)
        //{
        //    return await _httpClient.GetFromJsonAsync<IEnumerable<Document>>($"api/tasks/{taskId}/documents/{taskId}");
        //}

        //public async Task DeleteDocumentAsync(int taskId, int documentId)
        //{
        //    await _httpClient.DeleteAsync($"api/tasks/{taskId}/documents/{documentId}");
        //}

        //public async Task AddNoteAsync(int taskId, Note note)
        //{
        //    await _httpClient.PostAsJsonAsync($"api/tasks/{taskId}/notes", note);
        //}

        //public async Task<IEnumerable<Note>> GetNotesAsync(int taskId)
        //{
        //    return await _httpClient.GetFromJsonAsync<IEnumerable<Note>>($"api/tasks/{taskId}/notes/{taskId}");
        //}

        //public async Task DeleteNoteAsync(int taskId, int noteId)
        //{
        //    await _httpClient.DeleteAsync($"api/tasks/{taskId}/notes/{noteId}");
        //}
    }
}
