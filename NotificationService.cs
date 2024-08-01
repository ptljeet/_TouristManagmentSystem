namespace ProjectTouristManagmentSystem
{
    internal class NotificationService
    {
        private List<IObserver> observersList = new List<IObserver>();

        public void AddToObserversList(IObserver observer)
        {
            observersList.Add(observer);
        }

        public void RemoveFromObserversList(IObserver observer)
        {
            observersList.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observersList)
            {
                observer.Update(message);
            }
        }
    }
}
