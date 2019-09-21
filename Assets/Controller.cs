using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game;

namespace game
{
    public enum State { Left,Right,LTR,RTL,Win,Lose};

    public interface Action
    {
        void shipMove();
        void offShipLeft();
        void offShipRight();
        void restart();
        void priestLeftOnBoat();
        void priestRightOnBoat();
        void devilLeftOnBoat();
        void devilRightOnBoat();
    }

    public class SSDirector : System.Object, Action
    {
        private static SSDirector instance;
        private Model obj;
        private Controller controller;
        public State state = State.Left;

        public static SSDirector getInstance()
        {
            if(instance == null)
            {
                instance = new SSDirector();
            }
            return instance;
        }

        public Model getModel()
        {
            return obj;
        }
        internal void setModel(Model obj2)
        {
            if (obj == null)
            {
                obj = obj2;
            }
        }

        public void shipMove()
        {
            obj.shipMove();
        }

        public void offShipLeft()
        {
            obj.offShip(0);
        }

        public void offShipRight()
        {
            obj.offShip(1);
        }

        public void restart()
        {
            obj.restart();
        }

        public void priestLeftOnBoat()
        {
            obj.priestLeftOnBoat();
        }

        public void priestRightOnBoat()
        {
            obj.priestRightOnBoat();
        }

        public void devilLeftOnBoat()
        {
            obj.devilLeftOnBoat();
        }

        public void devilRightOnBoat()
        {
            obj.devilRightOnBoat();
        }
    }
}


public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
