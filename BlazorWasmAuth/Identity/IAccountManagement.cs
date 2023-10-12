using BlazorWasmAuth.Identity.Models;

namespace BlazorWasmAuth.Identity
{
    /// <summary>
    /// Account management services.
    /// </summary>
    public interface IAccountManagement
    {
        /// <summary>
        /// Login service.
        /// </summary>
        /// <param name="email">User's email.</param>
        /// <param name="password">User's password.</param>
        /// <returns>The result of the request serialized to <see cref="FormResult"/>.</returns>
        public Task<FormResult> LoginAsync(string email, string password);

        /// <summary>
        /// Registration service.
        /// </summary>
        /// <param name="email">User's email.</param>
        /// <param name="password">User's password.</param>
        /// <returns>The result of the request serialized to <see cref="FormResult"/>.</returns>
        public Task<FormResult> RegisterAsync(string email, string password);
    }
}
