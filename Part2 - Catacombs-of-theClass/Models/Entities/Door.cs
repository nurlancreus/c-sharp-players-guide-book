using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal enum DoorState
    {
        Closed,
        Opened,
        Locked,

    }

    internal class Door
    {
        private int _password;
        private DoorState _state = DoorState.Closed;

        public DoorState State
        {
            get => _state;
            private set
            {
                if (Enum.IsDefined(typeof(DoorState), value))
                {
                    _state = value;
                }
            }
        }

        public Door()
        {
            _password = 12345;
        }

        public void ChangeDoorState(string state)
        {
            switch (state.ToLower())
            {
                case "open":
                    Open();
                    break;
                case "close":
                    Close();
                    break;
                case "lock":
                    Lock();
                    break;
                case "unlock":
                    Unlock();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

        public bool Open()
        {
            if (State == DoorState.Closed)
            {
                State = DoorState.Opened;
                Console.WriteLine("You opened the door.");
                return true;
            }
            if (State == DoorState.Locked)
            {
                Console.WriteLine("The door is locked. Enter the password to unlock.");
                if (Unlock())
                {
                    State = DoorState.Opened;
                    Console.WriteLine("You opened the door.");
                    return true;
                }
                return false;
            }

            Console.WriteLine("The door is already open.");
            return false;
        }

        public bool Close()
        {
            if (State == DoorState.Opened)
            {
                State = DoorState.Closed;
                Console.WriteLine("You closed the door.");
                return true;
            }

            Console.WriteLine("The door is already closed.");
            return false;
        }

        public bool Lock()
        {
            if (State == DoorState.Opened)
            {
                Close();
            }

            if (State == DoorState.Closed)
            {
                State = DoorState.Locked;
                Console.WriteLine("You locked the door.");
                return true;
            }

            Console.WriteLine("The door is already locked.");
            return false;
        }

        public bool Unlock()
        {
            if (State != DoorState.Locked)
            {
                Console.WriteLine("The door is not locked.");
                return false;
            }

            Console.Write("Password: ");
            if (int.TryParse(Console.ReadLine(), out int pw) && pw == _password)
            {
                State = DoorState.Closed;
                Console.WriteLine("Correct password. You unlocked the door.");
                return true;
            }

            Console.WriteLine("Incorrect password. Try again.");
            return false;
        }

        public bool ChangePassword(int currentPw, int newPw)
        {
            if (currentPw == _password)
            {
                _password = newPw;
                Console.WriteLine("Password changed successfully.");
                return true;
            }

            Console.WriteLine("Incorrect current password. Cannot change the password.");
            return false;
        }

        public bool IsDoorUnlocked => State != DoorState.Locked;
    }
}
