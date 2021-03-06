﻿using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class InitializationCommandHandler : ICommandHandler<InitializationCommand>
    {
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public InitializationCommandHandler(IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        public void Handle(InitializationCommand command)
        {
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }

    internal class InitializationCommand : AmandaCommand
    {
    }
}
