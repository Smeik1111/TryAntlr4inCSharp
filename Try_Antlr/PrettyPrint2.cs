using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Antlr
{
    class PrettyPrint2
    {
        private static void SwapColors()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }

        private static void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if (right < 0) right = left + s.Length;
            while (Console.CursorLeft < right) Console.Write(s);
        }

        private static void PrintLink(int top, string start, string end, int startPos, int endPos)
        {
            Print(start, top, startPos);
            Print("─", top, startPos + 1, endPos);
            Print(end, top, endPos);
        }
        private static void Print(NodeInfo item, int top)
        {
            SwapColors();
            Print(item.Node.value, top, item.StartPos);
            SwapColors();

            if (item.Left != null)
                PrintLink(top + 1, "┌", "┘", item.Left.StartPos + item.Left.Size / 2, item.StartPos);
            if (item.Right != null)
                PrintLink(top + 1, "└", "┐", item.EndPos - 1, item.Right.StartPos + item.Right.Size / 2);
        }

        static int GetMaxSize(Antlr4.Runtime.Tree.IParseTree t)
        {
            var sizeOfChildren = 0;
            for (int i = 0; i < t.ChildCount; i++)
            {
                if (i > 0)
                {
                    sizeOfChildren += 2;
                }
                sizeOfChildren += GetMaxSize(t.GetChild(i));
            }
            var textOfNode = t.GetText();
            return Math.Max(sizeOfChildren, textOfNode.Length + 2);
        }

        void PrettyPrint(Antlr4.Runtime.Tree.IParseTree t)
        {
            List<List<string>> values = new();
            values.Add(new());

        }
        void AddValueToList(Antlr4.Runtime.Tree.IParseTree t, int Level, ref List<List<string>> values)
        {
            if (values.Count <= Level)
            {
                values.Add(new());
            }

            values[Level].Add(t.GetText());
            for (int i = 0; i < t.ChildCount; i++)
            {
                AddValueToList(t.GetChild(i), Level + 1, ref values);
            }
        }
    }
}
