﻿using CodeBase.Infrastructure.Game.UI;
using CodeBase.Infrastructure.Project.Services.StateMachine;

namespace CodeBase.Infrastructure.Game.States
{
    public class WaitingState : IState
    {
        private readonly GameUIFactory _gameUIFactory;
        private WaitingUI _waitingUI;

        public WaitingState(GameUIFactory gameUIFactory) => _gameUIFactory = gameUIFactory;

        public void Enter()
        {
            _gameUIFactory.Initialize();
            _waitingUI = _gameUIFactory.CreateWaitingUI();
            _waitingUI.InitializeUI();
        }

        public void Exit()
        {
            _waitingUI.DisposeUI();
            _gameUIFactory.DestroyWaitingUI(_waitingUI);
        }
    }
}