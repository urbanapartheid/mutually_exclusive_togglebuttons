namespace MutuallyExclusiveToggle
{
    public class ToggleControlVM
    {
        private bool _identifyOutputsActive;
        private bool _identifyScreensActive;

        public bool IdentifyOutputsActive
        {
            get
            {
                return _identifyOutputsActive;
            }

            set
            {
                if (_identifyOutputsActive != value)
                    _identifyOutputsActive = value;
            }
        }

        public bool IdentifyScreensActive
        {
            get
            {
                return _identifyScreensActive;
            }

            set
            {
                if (_identifyScreensActive != value)
                    _identifyScreensActive = value;
            }
        }
    }
}
