// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using Vlingo.Symbio;
using Vlingo.Symbio.Store.Dispatch;

namespace Vlingo.Lattice.Tests.Model.Object
{
    public class MockDispatcher : IDispatcher<Dispatchable<TextEntry, TextState>>
    {
        public void ControlWith(IDispatcherControl control)
        {
        }

        public void Dispatch(Dispatchable<TextEntry, TextState> dispatchable)
        {
        }
    }
}