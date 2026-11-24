using DSW_3P_EJ01.Models;
namespace DSW_3P_EJ01.Repositories;

public interface IPersonajeRepository
{
    List<Personaje> ObtenerTodos();
    Personaje? ObtenerPorId(int id);
    List<Personaje> ObtenerPorVideojuego(string videojuego);
    Personaje Agregar(Personaje nuevoPersonaje);
    bool Actualizar(int id, Personaje personaje);
    bool Eliminar(int id);
}