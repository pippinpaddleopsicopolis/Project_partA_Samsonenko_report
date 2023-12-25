using Project_partA_Samsonenko_report;
namespace Test
{
    [TestClass]
    public class FilmTests
    {
        [TestMethod]
        public void FilmConstructor_SetsPropertiesCorrectly()
        {
            // Arrange
            Director director = new Director("John", "Doe", 35, 50000);
            Worker actor = new Worker(1, "Alice", "Actress", 28, Job.Actor);
            Worker cinematographer = new Worker(2, "Bob", "Cinematographer", 40, Job.Cinematographer);
            List<Worker> workers = new List<Worker> { actor, cinematographer };

            // Act
            Film film = new Film("Awesome Film", director, workers);

            // Assert
            Assert.AreEqual("Awesome Film", film.Name);
            Assert.AreEqual(director, film.Owner);
            CollectionAssert.AreEqual(workers, film.Workers);
        }
    }

    [TestClass]
    public class DirectorTests
    {
        [TestMethod]
        public void DirectorConstructor_SetsPropertiesCorrectly()
        {
            // Arrange
            Director director = new Director("John", "Doe", 35, 50000);

            // Act & Assert
            Assert.AreEqual("John", director.FirstName);
            Assert.AreEqual("Doe", director.LastName);
            Assert.AreEqual(35, director.Age);
            Assert.AreEqual(50000, director.Income);
        }
    }
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void WorkerConstructor_SetsPropertiesCorrectly()
        {
            // Arrange
            Worker worker = new Worker(1, "Alice", "Actress", 28, Job.Actor);

            // Act & Assert
            Assert.AreEqual(1, worker.Id);
            Assert.AreEqual("Alice", worker.FirstName);
            Assert.AreEqual("Actress", worker.LastName);
            Assert.AreEqual(28, worker.Age);
            Assert.AreEqual(Job.Actor, worker.Job);
        }
    }

    [TestClass]
    public class CriticTests
    {
        [TestMethod]
        public void CriticConstructor_SetsPropertiesCorrectly()
        {
            // Arrange
            Film film = new Film("Awesome Film", new Director("John", "Doe", 35, 50000), new List<Worker>());
            Critic critic = new Critic(film, 4);

            // Act & Assert
            Assert.AreEqual(film, critic.Film);
            Assert.AreEqual(4, critic.Rating);
        }

        [TestMethod]
        public void PrintToDisplay_ReturnsCorrectString()
        {
            // Arrange
            Film film = new Film("Awesome Film", new Director("John", "Doe", 35, 50000), new List<Worker>());
            Critic critic = new Critic(film, 4);

            // Act
            string displayString = critic.PrintToDisplay();

            // Assert
            Assert.AreEqual($"Critic Rating for '{film.Name}': {critic.Rating}", displayString);
        }
    }
}