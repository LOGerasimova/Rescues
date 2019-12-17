namespace Rescues
{
    public class TooltipControllers
    {
        #region Fields

        private readonly GameContext _context;

        #endregion


        #region ClassLifeCycles

        public TooltipControllers(GameContext context, Services services)
        {
            _context = context;
        }

        #endregion


        #region IExecuteController

        public void IExecute()
        {
            foreach (var ItemBehaviour in _context.GetListInteractable())
            {
                if (ItemBehaviour.IsInteractable)
                {
                    if (ItemBehaviour is ItemBehaviour interactable)
                    {
                        //
                    }
                }
            }

            #endregion

        }
    }
}