using DSW_3P_EJ01.Models;

namespace DSW_3P_EJ01.Services;

public interface IPersonajeService
{
    List<Personaje> ObtenerTodos();
    Personaje? ObtenerPorId(int id);
    List<Personaje> ObtenerPorVideojuego(string videojuego);
    Personaje Agregar(Personaje nuevoPersonaje);
    bool Actualizar(int id, Personaje actualizado);
    bool Eliminar(int id);
}