namespace StatePattern
{
    public class DirectionService
    {
        private TravelMode _travelMode;

        public TravelMode GetTravelMode()
        {
            return _travelMode;
        }

        public void SetTravelMode(TravelMode travelMode)
        {
            _travelMode = travelMode;
        }

        public int GetEta()
        {
            return  this._travelMode.GetEta();

        }

        public int GetDirection()
        {
            return this._travelMode.GetDirection();
        }


    }
}
