namespace MovieApp.Domain.Entities.BaseEntities;

public interface IEntity<T>
{
    T Id { get; set; }
}
public abstract class Entity<T>:IEntity<T>
{
    public T Id { get; set; }
}

public abstract class Entity:Entity<int>
{
}


