using Microsoft.VisualBasic;
using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;
using System.Timers;
using static System.Formats.Asn1.AsnWriter;
using System.Drawing;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using static System.Collections.Specialized.BitVector32;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region LEVEL1
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL1************");
            //Console.WriteLine("******************************\n");
            //Console.WriteLine("Bread is ready.");
            //Console.WriteLine("Who is the bread for?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Noted: {name} got bread.");
            //#endregion;

            //#region LEVEL2
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL2************");
            //Console.WriteLine("******************************\n");
            ////  As you walk through the city of Commenton, admiring its forward-slash - based architectural buildings, a
            ////young man approaches you in a panic. “I dropped my Thing Namer 3000 and broke it.I think it’s mostly
            ////working, but all my variable names got reset! I don’t understand what they do !” He shows you the
            ////following program:

            //Console.WriteLine("What kind of thing are we talking about?");
            //// someone losed his thing we learn what is it
            //string thing = Console.ReadLine();

            //Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            //// what it looks like
            //string description = Console.ReadLine();

            //// we get full name of it
            //Console.WriteLine($"The {description} {thing} of Doom 300!");
            //#endregion;

            //#region LEVEL3
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL3************");
            //Console.WriteLine("******************************\n");

            ////string username;
            ////username = Console.ReadLine();
            ////Console.WriteLine("Hi " + username);
            ////string favoriteColor;
            ////favoriteColor = Console.ReadLine();
            ////Console.WriteLine("Hi " + favoriteColor);

            //#endregion;

            //#region LEVEL6
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL6************");
            //Console.WriteLine("******************************\n");

            ////  You see an old shopkeeper struggling to stack up variables in a window display. “Hoo - wee! All these
            ////variable types sure are exciting but setting them all up to show them off to excited new programmers
            ////like yourself is a lot of work for these aching bones,” she says. “You wouldn’t mind helping me set up this
            ////program with one variable of every type, would you ?”
            ////Objectives:
            ////• Build a program with a variable of all fourteen types described in this level.
            ////• Assign each of them a value using a literal of the correct type.
            ////• Use Console.WriteLine to display the contents of each variable.

            //string variableString = "Hello";
            //char variableChar = '0';
            //bool variableBool = false;

            //sbyte variableSbyte = -100;
            //Console.WriteLine(sbyte.MinValue);
            //Console.WriteLine(sbyte.MaxValue);

            //byte variableByte = 10;
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(byte.MaxValue);

            //short variableShort = -20;
            //Console.WriteLine(short.MinValue);
            //Console.WriteLine(short.MaxValue);

            //ushort variableUshort = 20;
            //Console.WriteLine(ushort.MinValue);
            //Console.WriteLine(ushort.MaxValue);

            //int variableInt = 100;
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //uint variableUint = 1000;
            //Console.WriteLine(uint.MinValue);
            //Console.WriteLine(uint.MaxValue);

            //long variableLong = 1000_000_000;
            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(long.MaxValue);

            //ulong variableUlong = 10000_0000_0000;
            //Console.WriteLine(ulong.MinValue);
            //Console.WriteLine(ulong.MaxValue);

            //float variableFLoat = 1000.57f;
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(float.PositiveInfinity);
            //Console.WriteLine(float.NegativeInfinity);
            //Console.WriteLine(float.NaN);

            //double variableDouble = 158.97d;
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.PositiveInfinity);
            //Console.WriteLine(double.NegativeInfinity);
            //Console.WriteLine(double.NaN);

            //decimal variableDecimal = 538.673m;
            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue);

            //// “Hey! Programmer!” It’s the shopkeeper from the Variable Shop who hobbles over to you. “Thanks to
            ////your help, variables are selling like RAM cakes! But these people just aren’t any good at programming.
            ////They keep asking how to modify the values of the variables they’re buying, and… well… frankly, I have no
            ////clue.But you’re a programmer, right? Maybe you could show me so I can show my customers?”

            ////Objectives:
            ////• Modify your Variable Shop program to assign a new, different literal value to each of the 14 original
            ////variables.Do not declare any additional variables.
            ////• Use Console.WriteLine to display the updated contents of each variable.

            //variableString = "Bye";
            //Console.WriteLine(variableString);

            //variableChar = 'A';
            //Console.WriteLine(variableChar);

            //variableBool = true;
            //Console.WriteLine(variableBool);

            //variableSbyte = 120;
            //Console.WriteLine(variableSbyte);

            //variableByte = 30;
            //Console.WriteLine(variableByte);

            //variableShort = -70;
            //Console.WriteLine(variableShort);

            //variableUshort = 50;
            //Console.WriteLine(variableUshort);

            //variableInt = 300;
            //Console.WriteLine(variableInt);

            //variableUint = 1050;
            //Console.WriteLine(variableUint);

            //variableLong = 1200_000_000;
            //Console.WriteLine(variableLong);

            //variableUlong = 4300_0500_0000;
            //Console.WriteLine(variableUlong);

            //variableFLoat = 1040.5f;
            //Console.WriteLine(variableFLoat);

            //variableDouble = 1583.97d;
            //Console.WriteLine(variableDouble);

            //variableDecimal = 1538.673m;
            //Console.WriteLine(variableDecimal);

            ////            Knowledge Check Type System 25 XP
            ////Check your knowledge with the following questions:
            ////1.True / False.The int type can store any possible integer. - FALSE
            ////2.Order the following by how large their range is, from smallest to largest: short, long, int, byte. - byte, short, int, long
            ////3.True / False.The byte type is signed. - FALSE
            ////4.Which can store higher numbers, int or uint? - UINT
            ////5.What three types can store floating - point numbers ? FLOAT, DOUBLE, DECIMAL
            ////6.Which of the options in question 5 can hold the largest numbers ? - DOUBLE
            ////7.Which of the options in question 5 is the most precise ? - DECIMAL
            ////8.What type does the literal value "8"(including the quotes) have ? - STRING
            ////9.What type stores true or false values? - BOOL

            //#endregion;

            //#region LEVEL7
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL7************");
            //Console.WriteLine("******************************\n");

            ////            As you pass through the fields near Arithmetica City, you encounter P - Thag, a triangle farmer, scratching
            ////numbers in the dirt.
            ////“What is all of that writing for?” you ask.
            ////“I’m just trying to calculate the area of all of my triangles.They sell by their size.The bigger they are, the
            ////more they are worth! But I have many triangles on my farm, and the math gets tricky, and I sometimes
            ////make mistakes.Taking a tiny triangle to town thinking you’re going to get 100 gold, only to be told it’s
            ////only worth three, is not fun! If only I had a program that could help me….” Suddenly, P - Thag looks at you
            ////with fresh eyes. “Wait just a moment.You have the look of a Programmer about you.Can you help me
            ////write a program that will compute the areas for me, so I can quit worrying about math mistakes and get
            ////back to tending to my triangles ? The equation I’m using is this one here,” he says, pointing to the formula,
            ////etched in a stone beside him:
            ////𝐴𝐴𝐴𝐴𝐴𝐴𝐴𝐴 =
            ////𝑏𝑏𝑏𝑏𝑏𝑏𝑏𝑏 × ℎ𝑒𝑒𝑒𝑒𝑒𝑒ℎ𝑡𝑡
            ////2
            ////Objectives:
            ////• Write a program that lets you input the triangle’s base size and height.
            ////• Compute the area of a triangle by turning the above equation into code.
            ////• Write the result of the computation.

            //Console.WriteLine("Input triangle's base size and height");
            //Console.Write("Input triangle's base size: ");
            //int baseSize = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input triangle's height: ");
            //int height = Convert.ToInt32(Console.ReadLine());

            //float area = (float)baseSize * height / 2;
            //Console.WriteLine($"Triangle's area is {area}");

            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");


            ////            Four sisters own a chocolate farm and collect chocolate eggs laid by chocolate chickens every day. But
            ////more often than not, the number of eggs is not evenly divisible among the sisters, and everybody knows
            ////you cannot split a chocolate egg into pieces without ruining it. The arguments have grown more heated
            ////over time. The town is tired of hearing the four sisters complain, and Chandra, the town’s Arbiter, has
            ////finally come up with a plan everybody can agree to.All four sisters get an equal number of chocolate
            ////eggs every day, and the remainder is fed to their pet duckbear.All that is left is to have some skilled
            ////Programmer build a program to tell them how much each sister and the duckbear should get.
            ////Objectives:
            ////• Create a program that lets the user enter the number of chocolate eggs gathered that day.
            ////• Using / and %, compute how many eggs each sister should get and how many are left over for the
            ////duckbear.
            ////• Answer this question: What are three total egg counts where the duckbear gets more than each
            ////sister does ? You can use the program you created to help you find the answer.

            //const byte SISTERS_COUNT = 4;

            //Console.WriteLine("Input the number of eggs");

            //sbyte numberOfEggs = Convert.ToSByte(Console.ReadLine());

            //int eachSistersShare = numberOfEggs / SISTERS_COUNT;
            //int ducksShare = numberOfEggs % SISTERS_COUNT;

            //Console.WriteLine("Sisters share " + eachSistersShare);
            //Console.WriteLine("Ducks share " + ducksShare);

            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");

            ////            Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom
            ////among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree
            ////to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every
            ////duchy is worth 3 points, and every province is worth 6 points.They just need a program that will allow
            ////them to enter their current holdings and compute a point total.
            ////Objectives:
            ////• Create a program that allows users to enter how many provinces, duchies, and estates they have.
            ////• Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
            ////• Display the point total to the user.

            //Console.WriteLine("How many estates do you have?");
            //int estateCount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("How many duchies do you have?");
            //int duchyCount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("How many provinces do you have?");
            //int provinceCount = Convert.ToInt32(Console.ReadLine());

            //int total = estateCount * 1 + duchyCount * 3 + provinceCount * 6;

            //Console.WriteLine("Your point total: " + total);

            ///* NOTES */

            //// If you divide by zero with integer types, your program will produce an error that, if left
            ////unhandled, will crash your program. We talk about error handling of this nature in Level 35.
            ////If you divide by zero with floating - point types, you do not get the same kind of crash. Instead,
            ////it assumes that you actually wanted to divide by an impossibly tiny but non-zero number(an
            ////“infinitesimal” number), and the result will either be positive infinity, negative infinity, or NaN
            ////depending on whether the numerator was a positive number, negative number, or zero
            ////respectively.Mathematical operations with infinities and NaNs always result in more infinities
            ////and NaNs, so you will want to protect yourself against dividing by zero in the first place when
            ////you can.

            //#endregion;

            //#region LEVEL8
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL8************");
            //Console.WriteLine("******************************\n");

            ////            Challenge The Defense of Consolas 200 XP
            ////The Uncoded One has begun an assault on the city of Consolas; the
            ////situation is dire.From a moving airship called the Manticore,
            ////massive fireballs capable of destroying city blocks are being
            ////catapulted into the city.
            ////The city is arranged in blocks, numbered like a chessboard.
            ////The city’s only defense is a movable magical barrier, operated by a
            ////squad of four that can protect a single city block by putting
            ////themselves in each of the target’s four adjacent blocks, as shown in
            ////the picture to the right.
            ////            For example, to protect the city block at(Row 6, Column 5), the
            ////crew deploys themselves to(Row 6, Column 4), (Row 5, Column 5),
            ////(Row 6, Column 6), and(Row7, Column 5).
            ////The good news is that if we can compute the deployment locations fast enough, the crew can be
            ////deployed around the target in time to prevent catastrophic damage to the city for as long as the siege
            ////lasts.The City of Consolas needs a program to tell the squad where to deploy, given the anticipated
            ////target.Something like this:
            ////Target Row ? 6
            ////Target Column ? 5
            ////Deploy to:
            ////(6, 4)
            ////(5, 5)
            ////(6, 6)
            ////(7, 5)

            ////Objectives:
            ////• Ask the user for the target row and column.
            ////• Compute the neighboring rows and columns of where to deploy the squad.
            ////• Display the deployment instructions in a different color of your choosing.
            ////• Change the window title to be “Defense of Consolas”.
            ////• Play a sound with Console.Beep when the results have been computed and displayed.

            //Console.Title = "Defense of Consolas";
            //Console.WriteLine("Choose target row and target column. in order to protect city blocks");
            //Console.Write("Target Row? ");
            //byte targetRow = Convert.ToByte(Console.ReadLine());

            //Console.Write("Target Column? ");
            //byte targetColumn = Convert.ToByte(Console.ReadLine());

            //Console.WriteLine($"({targetRow}, {targetColumn - 1})\n({targetRow - 1}, {targetColumn})\n({targetRow}, {targetColumn + 1})\n({targetRow + 1}, {targetColumn})");
            //Console.Beep();
            //#endregion;

            //#region LEVEL9
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL9************");
            //Console.WriteLine("******************************\n");

            ////            Challenge Repairing the Clocktower 100 XP
            ////The recent attacks damaged the great Clocktower of Consolas. The citizens of Consolas have repaired
            ////most of it, except one piece that requires the steady hand of a Programmer.It is the part that makes the
            ////clock tick and tock.Numbers flow into the clock to make it go, and if the number is even, the clock’s
            ////pendulum should tick to the left; if the number is odd, the pendulum should tock to the right.Only a
            ////programmer can recreate this critical clock element to make it work again.
            ////Objectives:
            ////• Take a number as input from the console.
            ////• Display the word “Tick” if the number is even.Display the word “Tock” if the number is odd.
            ////• Hint: Remember that you can use the remainder operator to determine if a number is even or odd.

            //Console.Write("Input the hour: ");
            //int hour = Convert.ToInt32(Console.ReadLine());

            //hour = hour > 24 ? hour % 24 : hour;

            //Console.WriteLine($"Hour: {hour}");
            //if (hour % 2 == 0) Console.WriteLine("Tick");
            //else Console.WriteLine("Tock");


            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");

            ////            Challenge Watchtower 100 XP
            ////There are watchtowers in the region around Consolas that can alert
            ////you when an enemy is spotted.With some help from you, they can tell
            ////you which direction the enemy is from the watchtower.
            ////Objectives:
            ////• Ask the user for an x value and a y value.These are coordinates of
            ////the enemy relative to the watchtower’s location.
            ////• Using the image on the right, if statements, and relational
            ////operators, display a message about what direction the enemy is
            ////coming from. For example, “The enemy is to the northwest!” or
            ////“The enemy is here!”

            //Console.WriteLine("Enter the coords of the enemy! (x & y)");
            //Console.Write("X: ");
            //int xCoords = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Y: ");
            //int yCoords = Convert.ToInt32(Console.ReadLine());

            //string message = "The enemy is ";

            //if (yCoords > 0)
            //{
            //    if (xCoords > 0) message += "to the North East";
            //    else if (xCoords < 0) message += "to the North West";
            //    else message += "to the North";
            //}
            //else if (yCoords < 0)
            //{
            //    if (xCoords > 0) message += "to the South East";
            //    else if (xCoords < 0) message += "to the South West";
            //    else message += "to the South";

            //}
            //else
            //{
            //    if (xCoords > 0) message += "to the East";
            //    else if (xCoords < 0) message += "to the West";
            //    else message += "here!";
            //}

            //Console.WriteLine(message);
            //#endregion;

            //#region LEVEL10
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL10***********");
            //Console.WriteLine("******************************\n");


            ////            SWITCH EXPRESSIONS
            ////Switches also come in an expression format as well.In expression form, each arm is an
            ////expression, and the whole switch is also an expression.Our pirate menu looks like this when
            ////written as a switch expression:

            ////Console.WriteLine("Choose 1-4 options");
            ////int choice = Convert.ToInt32(Console.ReadLine());
            ////string response;
            ////response = choice switch
            ////{
            ////    1 => "Ye rest and recover your health.",
            ////    2 => "Raiding the port town get ye 50 gold doubloons.",
            ////    3 => "The wind is at your back; the open horizon ahead.",
            ////    4 => "'Tis but a baby Kraken, but still eats toy boats.",
            ////    _ => "Apologies. I do not know that one."
            ////};
            ////Console.WriteLine(response);


            ////            A switch expression has a lot in common with a switch statement structurally but also has
            ////quite a few differences. For starters, in a switch expression, the switch’s target comes before
            ////the switch keyword instead of after.
            ////Aside from that difference, much of the clutter has been removed or simplified to produce
            ////more streamlined code. The case labels are gone, replaced with just the specific value you
            ////want to check for. Each arm also has that arrow operator (=>), which separates the arm’s
            ////condition from its expression.The breaks are also gone; each arm can have only one
            ////expression, so the need to indicate the end is gone.
            ////82 LEVEL 10 SWITCHES
            ////Each arm is separated by a comma, though it is typical to put arms on separate lines.
            ////The default keyword is also gone, replaced with a single underscore—the “wildcard.”
            ////Switch expressions do not need a wildcard but often have one.If there is no match on a switch
            ////statement, the default behavior is to do nothing.No problem there.With a switch expression,
            ////the overall expression has to evaluate to something, and if it can’t find an expression to
            ////evaluate, the program will crash.So switch expressions should either provide a default
            ////through a wildcard or ensure that the other arms cover all possible scenarios.
            ////Both flavors of switches, as well as if/else statements, have their uses.One is not universally
            ////better than the others.You will generally want to pick the version that results in the cleanest,
            ////simplest code for the job.

            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");

            ////            Challenge Buying Inventory 100 XP
            ////It is time to resupply.A nearby outfitter shop has the supplies you need but is so disorganized that they
            ////cannot sell things to you. “Can’t sell if I can’t find the price list,” Tortuga, the owner, tells you as he turns
            ////over and attempts to go back to sleep in his reclining chair in the corner.
            ////There’s a simple solution: use your programming powers to build something to report the prices of
            ////various pieces of equipment, based on the user’s selection:
            ////The following items are available:
            ////1 – Rope
            ////2 – Torches
            ////3 – Climbing Equipment
            ////4 – Clean Water
            ////5 – Machete
            ////6 – Canoe
            ////7 – Food Supplies
            ////What number do you want to see the price of? 2
            ////Torches cost 15 gold.
            ////You search around the shop and find ledgers that show the following prices for these items: Rope: 10
            ////gold, Torches: 15 gold, Climbing Equipment: 25 gold, Clean Water: 1 gold, Machete: 20 gold, Canoe: 200
            ////gold, Food Supplies: 1 gold.
            ////Objectives:
            ////• Build a program that will show the menu illustrated above.
            ////• Ask the user to enter a number from the menu.
            ////• Using the information above, use a switch (either type) to show the item’s cost.


            ////            Challenge Discounted Inventory 50 XP
            ////After sorting through Tortuga’s outfitter shop and making it viable again, Tortuga realizes you’ve put him
            ////back in business.He wants to repay the favor by giving you a 50 % discount on anything you buy from
            ////him, and he wants you to modify your program to reflect that.
            ////After asking the user for a number, the program should also ask for their name. If the name supplied is
            ////your name, cut the price in half before reporting it to the user.
            ////Objectives:
            ////• Modify your program from before to also ask the user for their name.
            ////• If their name equals your name, divide the cost in half.

            //Console.WriteLine("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");
            //Console.Write("What number do you want to see the price of? ");
            //byte choice = Convert.ToByte(Console.ReadLine());
            //string programmerName = "Nurlan";
            //Console.Write("Also what is your name: ");
            //string userName = Console.ReadLine().ToLower();

            //const int ropePrice = 10;
            //const int torchesPrice = 15;
            //const int climbingEquipPrice = 25;
            //const int cleanWaterPrice = 1;
            //const int machetePrice = 20;
            //const int canoePrice = 200;
            //const int foodPrice = 1;

            //float price = 0;
            //string productName = "";
            //bool isChoiceOnTheMenu = true;

            //float discount = (float)(userName == programmerName.ToLower() ? 0.5 : 1.0);

            //switch (choice)
            //{
            //    case 1:
            //        price = ropePrice * discount;
            //        productName = "Rope";
            //        break;
            //    case 2:
            //        price = torchesPrice * discount;
            //        productName = "Torches";
            //        break;
            //    case 3:
            //        price = climbingEquipPrice * discount;
            //        productName = "Climbing Equipments";
            //        break;
            //    case 4:
            //        price = cleanWaterPrice * discount;
            //        productName = "Clean Water";
            //        break;
            //    case 5:
            //        price = machetePrice * discount;
            //        productName = "Machete";
            //        break;
            //    case 6:
            //        price = canoePrice * discount;
            //        productName = "Canoe";
            //        break;
            //    case 7:
            //        price = foodPrice * discount;
            //        productName = "Food Supplies";
            //        break;
            //    default:
            //        isChoiceOnTheMenu = false;
            //        Console.WriteLine("Please, choose something from the menu.");
            //        break;
            //}

            //if (isChoiceOnTheMenu)
            //    Console.WriteLine($"{productName} costs {price} gold");


            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");


            //#endregion;

            //#region LEVEL11
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL11***********");
            //Console.WriteLine("******************************\n");

            ////            Challenge The Prototype 100 XP
            ////Mylara, the captain of the Guard of Consolas, has approached you with the beginnings of a plan to hunt
            ////down The Uncoded One’s airship. “If we’re going to be able to track this thing down,” she says, “we need
            ////you to make us a program that can help us home in on a location.” She lays out a plan for a program to
            ////help with the hunt.One user, representing the airship pilot, picks a number between 0 and 100.Another
            ////user, the hunter, will then attempt to guess the number.The program will tell the hunter that they
            ////guessed correctly or that the number was too high or low.The program repeats until the hunter guesses
            ////the number correctly.Mylara claims, “If we can build this program, we can use what we learn to build a
            ////better version to hunt down the Uncoded One’s airship.”

            ////Sample Program:
            ////User 1, enter a number between 0 and 100: 27
            ////After entering this number, the program should clear the screen and continue like this:
            ////User 2, guess the number.
            ////What is your next guess ? 50
            ////50 is too high.
            ////What is your next guess ? 25
            ////25 is too low.
            ////What is your next guess ? 27
            ////You guessed the number!
            ////Objectives:
            ////• Build a program that will allow a user, the pilot, to enter a number.
            ////• If the number is above 100 or less than 0, keep asking.
            ////• Clear the screen once the program has collected a good number.
            ////• Ask a second user, the hunter, to guess numbers.
            ////• Indicate whether the user guessed too high, too low, or guessed right.
            ////• Loop until they get it right, then end the program.

            //Console.Write("User 1, enter a number between 0 and 100: ");
            //int selectedNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();


            //while (true)
            //{
            //    Console.Write("User 2, guess the number: ");
            //    int guessedNumber = Convert.ToInt32(Console.ReadLine());

            //    if (guessedNumber == selectedNumber)
            //    {
            //        Console.WriteLine($"You guessed right! Number is {selectedNumber}");
            //        break;
            //    }
            //    else if (guessedNumber > selectedNumber)
            //    {
            //        Console.WriteLine($"{guessedNumber} is high. Try lower!");
            //    }
            //    else if (guessedNumber < selectedNumber)
            //    {
            //        Console.WriteLine($"{guessedNumber} is low. Try higher");
            //    }
            //}


            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");

            ////            Challenge The Magic Cannon 100 XP
            ////Skorin, a member of Consolas’s wall guard, has constructed a magic cannon that draws power from two
            ////gems: a fire gem and an electric gem.Every third turn of a crank, the fire gem activates, and the cannon
            ////produces a fire blast.The electric gem activates every fifth turn of the crank, and the cannon makes an
            ////electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to
            ////produce a program that can warn the crew about which turns of the crank will produce the different
            ////blasts before they do it.
            ////A partial output of the desired program looks like this:
            ////1: Normal
            ////2: Normal
            ////3: Fire
            ////4: Normal
            ////5: Electric
            ////6: Fire
            ////7: Normal
            ////...
            ////Objectives:
            ////• Write a program that will loop through the values between 1 and 100 and display what kind of blast
            ////the crew should expect. (The % operator may be of use.)
            ////• Change the color of the output based on the type of blast. (For example, red for Fire, yellow for
            ////Electric, and blue for Electric and Fire).

            //string output;
            //ConsoleColor color;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 00 && i % 5 == 0)
            //    {
            //        color = ConsoleColor.Blue;
            //        output = $"{i}: Electric and Fire";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        color = ConsoleColor.Red;
            //        output = $"{i}: Fire";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        color = ConsoleColor.Yellow;
            //        output = $"{i}: Electric";
            //    }
            //    else
            //    {
            //        color = ConsoleColor.Gray;
            //        output = $"{i}: Normal";
            //    }

            //    Console.ForegroundColor = color;
            //    Console.WriteLine(output);
            //    Console.ResetColor();
            //}

            //#endregion;

            //#region LEVEL12
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL12***********");
            //Console.WriteLine("******************************\n");

            ////            Default Values
            ////When a new array is created, the computer will take the array’s memory location and set every
            ////bit to 0.This automatically initializes every spot in an array, but what does it initialize it to?
            ////The meaning of “every bit is 0” depends on the type. For every numeric type, including both
            ////integers and floating-point types, this is the number 0.For bool, this is false.For a
            ////character, this is a special character called the null character.For a string, it is a thing that
            ////represents a missing or non-existent value called null.We’ll learn more about null values later.
            ////For now, treat null strings as though they were uninitialized.
            ////But the good part is that we don’t need to go through a whole array and populate it with
            ////specific values if the default value is good enough. For example, suppose we do this:
            ////int[] scores = new int[5];
            ////            This array of length five will contain five spots, each with a value of 0.

            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");


            ////            Challenge The Replicator of D’To 100 XP
            ////While searching an abandoned storage building containing strange code artifacts, you uncover the
            ////ancient Replicator of D’To.This can replicate the contents of any int array into another array.But it
            ////appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
            ////Objectives:
            ////• Make a program that creates an array of length 5.
            ////• Ask the user for five numbers and put them in the array.
            ////• Make a second array of length 5.
            ////• Use a loop to copy the values out of the original array and into the new one.
            ////• Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
            ////again.

            //int[] arrOg = new int[5];

            //Console.WriteLine("Set array numbers");

            //for (int i = 0; i < arrOg.Length; i++)
            //{
            //    Console.Write("index {0}: ", i);
            //    arrOg[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int[] arrCopy = new int[5];

            //for (int i = 0; i < arrOg.Length; i++)
            //{
            //    arrCopy[i] = arrOg[i];
            //    Console.WriteLine($"Og: {string.Join(", ", arrOg)} - Copy: {string.Join(", ", arrCopy)}");
            //}

            //for (int i = 0; i < arrCopy.Length; i++)
            //{
            //    Console.WriteLine($"Og: {arrOg[i]} - Copy: {arrCopy[i]}");

            //}

            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");

            ////            Challenge The Laws of Freach 50 XP
            ////The town of Freach recently had an awful looping disaster.The lead investigator found that it was a faulty
            ////++ operator in an old for loop, but the town council has chosen to ban all loops but the foreach loop.
            ////Yet Freach uses the code presented earlier in this level to compute the minimum and the average value
            ////in an int array. They have hired you to rework their existing for-based code to use foreach loops
            ////                instead.
            ////Objectives:
            ////• Start with the code for computing an array’s minimum and average values in the section Some
            ////Examples with Arrays, starting on page 94.
            ////• Modify the code to use foreach loops instead of for loops.

            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            //int currentMinValue = array[0];
            //int sum = 0;

            //foreach (int num in array)
            //{
            //    if (num < currentMinValue) currentMinValue = num;
            //    sum += num;
            //}

            //Console.WriteLine($"Minimum value from {string.Join(", ", array)} is {currentMinValue}");
            //Console.WriteLine($"The average value of {string.Join(", ", array)} is {Math.Round((float)sum / array.Length, 2)}");

            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");

            ////            Multi - dimensional arrays can have as many dimensions as you need(for example,
            ////bool[,,]), and you can have multi - dimensional arrays of regular arrays or regular arrays of
            ////multi - dimensional arrays(int[,][], float[][,,,], etc.).These get tough to understand
            ////very quickly, so proceed with caution.
            ////To loop through all elements in a multi-dimensional array, you will probably want to use the
            ////GetLength method, handing it the dimension you are interested in (starting with 0, not 1):

            //int[,] matrix = new int[4, 4];
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int column = 0; column < matrix.GetLength(1); column++)
            //        Console.Write(matrix[row, column] + " ");
            //    Console.WriteLine();
            //}

            //#endregion;

            //#region LEVEL13
            //Console.WriteLine("******************************");
            //Console.WriteLine("************LEVEL13***********");
            //Console.WriteLine("******************************\n");

            ////            Challenge Taking a Number 100 XP
            ////Many previous tasks have required getting a number from a user. To save time writing this code
            ////repeatedly, you have decided to make a method to do this common task.
            ////Objectives:
            ////• Make a method with the signature int AskForNumber(string text). Display the text
            ////parameter in the console window, get a response from the user, convert it to an int, and return it.
            ////This might look like this: int result = AskForNumber("What is the airspeed velocity
            ////of an unladen swallow ? ");.
            ////• Make a method with the signature int AskForNumberInRange(string text, int min, int
            ////max).Only return if the entered number is between the min and max values. Otherwise, ask again.
            ////• Place these methods in at least one of your previous programs to improve it.

            //int AskForNumber(string text, int min, int max)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            Console.WriteLine($"{text} ({min} - {max})");
            //            int num = Convert.ToInt32(Console.ReadLine());

            //            if (num >= min && num <= max) return num;
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
            //    }
            //}


            //AskForNumber("Enter a number between given the ranges", 0, 100);


            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");
            //Console.WriteLine("*********************");

            ////            Challenge Countdown 100 XP
            ////Note: This challenge requires reading The Basics of Recursion side quest to attempt.
            ////The Council of Freach has summoned you.New writing has appeared on the Tomb of Algol the Wise, the
            ////last True Programmer to wander this land.The writing strikes fear and awe into the hearts of the looploving
            ////people of Freach: “The next True Programmer shall be able to write any looping code with a
            ////method call instead.” The Senior Counselor, scared of a world without loops, asks you to put your skill to
            ////the test and rewrite the following code, which counts down from 10 to 1, with no loops:

            ////for (int x = 10; x > 0; x--)
            ////                Console.WriteLine(x);
            ////            As you consider the words on the Tomb of Algol the Wise, you begin to think it might be correct and that
            ////            you might be able to write this code using recursion instead of a loop.
            ////            Objectives:
            ////• Write code that counts down from 10 to 1 using a recursive method.
            ////• Hint: Remember that you must have a base case that ends the recursion and that every time you
            ////call the method recursively, you must be getting closer and closer to that base case.

            //void CountDown(int num)
            //{
            //    if (num <= 0) return;
            //    Console.WriteLine(num);

            //    CountDown(--num);
            //}

            //CountDown(AskForNumber("Start Countdown", 0, 10));

            //#endregion;

            #region LEVEL14
            Console.WriteLine("******************************");
            Console.WriteLine("************LEVEL14***********");
            Console.WriteLine("******************************\n");

            //            Knowledge Check Memory 25 XP
            //Check your knowledge with the following questions:
            //1.True / False.You can access anything on the stack at any time. - FALSE
            //2.True / False.The stack keeps track of local variables. - TRUE
            //3.True / False.The contents of a value type can be placed on the heap. - TRUE
            //4.True / False.The contents of a value type are always placed on the heap. - FALSE
            //5.True / False.The contents of reference types are always placed on the heap. - TRUE
            //6.True / False.The garbage collector cleans up old, unused space on the heap and stack. - FALSE
            //7.True / False.If a and b are array variables referencing the same object, modifying a affects b as well. - TRUE
            //8.True / False.If a and b are ints with the same value, changing a will also affect b. - FALSE

            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");

            //            Boss Battle Hunting the Manticore 250 XP
            //The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be
            //destroyed, or the city will fall. Only by combining Mylara’s prototype, Skorin’s cannon, and your
            //programming skills will you have a chance to win this fight.You must build a program that allows one
            //user—the pilot of the Manticore—to enter the airship’s range from the city and a second user—the city’s
            //defenses—to attempt to find what distance the airship is at and destroy it before it can lay waste to the
            //town.
            //The first user begins by secretly establishing how far the Manticore is from the city, in the range 0 to 100.
            //The program then allows a second player to repeatedly attempt to destroy the airship by picking the
            //range to target until either the city of Consolas or the Manticore is destroyed.In each attempt, the player
            //is told if they overshot(too far), fell short(not far enough), or hit the Manticore. The damage dealt to the
            //Manticore depends on the turn number.For most turns, 1 point of damage is dealt.But if the turn number
            //is a multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an electric blast deals 3 points of
            //damage, and if it is a multiple of both 3 and 5, a mighty fire - electric blast deals 10 points of damage.The
            //Manticore is destroyed after taking 10 points of damage.
            //However, if the Manticore survives a turn, it will deal a guaranteed 1 point of damage to the city of
            //Consolas.The city can only take 15 points of damage before being annihilated.
            //Before a round begins, the user should see the current status: the current round number, the city’s health,
            //and the Manticore’s health.
            //A sample run of the program is shown below. The first player gets a chance to place the Manticore:
            //Player 1, how far away from the city do you want to station the Manticore ? 32
            //At this point, the display is cleared, and the second player gets their chance:
            //            Player 2, it is your turn.
            //-----------------------------------------------------------
            //STATUS: Round: 1 City: 15 / 15 Manticore: 10 / 10
            //The cannon is expected to deal 1 damage this round.
            //Enter desired cannon range: 50
            //That round OVERSHOT the target.
            //---------------------------------------------------------- -
            //STATUS: Round: 2 City: 14 / 15 Manticore: 10 / 10
            //The cannon is expected to deal 1 damage this round.
            //Enter desired cannon range: 25
            //That round FELL SHORT of the target.
            //---------------------------------------------------------- -
            //STATUS: Round: 3 City: 13 / 15 Manticore: 10 / 10
            //The cannon is expected to deal 3 damage this round.
            //Enter desired cannon range: 32
            //That round was a DIRECT HIT!
            //-----------------------------------------------------------
            //STATUS: Round: 4 City: 12 / 15 Manticore: 7 / 10
            //The cannon is expected to deal 1 damage this round.
            //Enter desired cannon range: 32
            //That round was a DIRECT HIT!
            //-----------------------------------------------------------
            //STATUS: Round: 5 City: 11 / 15 Manticore: 6 / 10
            //The cannon is expected to deal 3 damage this round.
            //Enter desired cannon range: 32
            //That round was a DIRECT HIT!
            //-----------------------------------------------------------
            //STATUS: Round: 6 City: 10 / 15 Manticore: 3 / 10
            //The cannon is expected to deal 3 damage this round.
            //Enter desired cannon range: 32
            //That round was a DIRECT HIT!
            //The Manticore has been destroyed!The city of Consolas has been saved!

            //        Objectives:
            //• Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15.
            //The game starts at round 1.
            //• Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen
            //afterward.
            //• Run the game in a loop until either the Manticore’s or city’s health reaches 0.
            //• Before the second player’s turn, display the round number, the city’s health, and the Manticore’s
            //health.
            //• Compute how much damage the cannon will deal this round: 10 points if the round number is a
            //multiple of both 3 and 5, 3 if it is a multiple of 3 or 5(but not both), and 1 otherwise.Display this to
            //the player.
            //• Get a target range from the second player, and resolve its effect. Tell the user if they overshot(too
            //far), fell short, or hit the Manticore.If it was a hit, reduce the Manticore’s health by the expected
            //amount.
            //• If the Manticore is still alive, reduce the city’s health by 1.
            //• Advance to the next round.
            //• When the Manticore or the city’s health reaches 0, end the game and display the outcome.
            //• Use different colors for different types of messages.
            //• Note: This is the largest program you have made so far.Expect it to take some time!
            //• Note: Use methods to focus on solving one problem at a time.
            //• Note: This version requires two players, but in the future, we will modify it to allow the computer
            //to randomly place the Manticore so that it can be a single - player game.

            void CustomLog(string message, string result)
            {
                Console.BackgroundColor = result == "lost" ? ConsoleColor.Red : ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                Console.ResetColor();
            }

            int AskForNumber(string text, int min = 0, int max = 100)
            {

                while (true)
                {
                    Console.Write($"{text} ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number >= min && number <= max)
                        return number;
                }
            }

            int GetExpectedDamage(int round)
            {
                if (round % 3 == 0 && round % 5 == 0) return 10;
                else if (round % 3 == 0) return 3;
                else if (round % 5 == 0) return 3;
                else return 1;
            }

            int cityHP = 15;
            int manticoreHP = 10;

            int player1 = AskForNumber("Player 1, how far away from the city do you want to station the Manticore?");
            Console.Clear();
            Console.WriteLine("Player 2, it is your turn.");

            int round = 1;
            while (true)
            {
                //            STATUS: Round: 1 City: 15 / 15 Manticore: 10 / 10
                //The cannon is expected to deal 1 damage this round.
                //Enter desired cannon range: 50
                //That round OVERSHOT the target.

                Console.WriteLine($"\nSTATUS: Round: {round} City: {cityHP} / 15 Manticore: {manticoreHP} / 10");
                Console.WriteLine($"\nThe cannon is expected to deal {GetExpectedDamage(round)} damage this round");
                int player2 = AskForNumber("\nEnter desired cannon range:");
                Console.Clear();
                if (player2 < player1)
                {
                    Console.WriteLine("\nThat round FELL SHORT of the target.");
                    cityHP--;
                }
                else if (player2 > player1)
                {
                    Console.WriteLine("\nThat round OVERSHOT the target.");
                    cityHP--;
                }
                else if (player2 == player1)
                {
                    Console.WriteLine("\nThat round was a DIRECT HIT!");
                    manticoreHP -= GetExpectedDamage(round);
                };

                if (manticoreHP <= 0)
                {
                    CustomLog("\nThe Manticore has been destroyed! The city of Consolas has been saved!", "won");
                    break;
                }
                else if (cityHP <= 0)
                {
                    CustomLog("\nThe City has been destroyed! We lost!", "lost");
                    break;
                }

                round++;
            }

            #endregion;
        }
    }

}
