using System;
using HarmonyLib;
using BartInBBPlus;
using UnityEngine;

namespace BartInBBPlus.NPCs {
    public class Bart : NPC {
        public override void Initialize()
        {
            
                        base.Initialize();
                        this.spriteRenderer[0].sprite = (Sprite)BasePlugin.Instance.ModAssets.GetAsset("Bart");
                        float ingameSize = 8f;
                        float ingameFloat = 0f;
                        this.spriteRenderer[0].transform.position += Vector3.down * this.spriteRenderer[0].transform.position.y + Vector3.up * (ingameFloat + ingameSize * 0.5f);
                        this.spriteRenderer[0].transform.localScale *= ingameSize;
                        this.audMan = base.GetComponent<PropagatedAudioManager>();
                        base.Navigator.SetRoomAvoidance(false);
                        base.Navigator.SetSpeed(this.WalkSpeed);
                        base.Navigator.maxSpeed = this.WalkSpeed;
                        //this.behaviorStateMachine.ChangeState(new Bart_State(this)); - not yet implemented
                        AccessTools.Field(typeof(AudioManager), "overrideSubtitleColor").SetValue(this.audMan, false);
            			this.audMan.QueueAudio((SoundObject)BasePlugin.Instance.ModAssets.GetAsset("Simpson_Gamer"));
			            this.audMan.SetLoop(true);
            
        }
        public float WalkSpeed = 16f;

        public float RunSpeed = 16f;

        public AudioManager audMan;
    }
    }
    