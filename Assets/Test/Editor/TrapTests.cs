using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NSubstitute;
using UnityEngine;

public class TrapTests{
    [Test]
    public void PlayerEntering_PlayerTargetedTrap_ReducesHealthByOne(){
        Trap trap = new Trap();
        IPlayer player = Substitute.For<IPlayer>();
        player.IsPlayer.Returns(true);
        trap.HandleCharacterEntered(player, TrapTargetType.Player);
        Assert.AreEqual(-1, player.Health);
    }

    [Test]
    public void NpcEntering_NpcTargetedTrap_ReducesHealthByOne(){
        Trap trap = new Trap();
        IPlayer player = Substitute.For<IPlayer>();
        trap.HandleCharacterEntered(player, TrapTargetType.Npc);
        Assert.AreEqual(-1, player.Health);
    }
}
