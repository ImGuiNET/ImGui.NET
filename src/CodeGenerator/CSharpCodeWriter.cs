using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeGenerator
{
    class CSharpCodeWriter : IDisposable
    {
        private readonly StreamWriter _sw;
        private int _indentLevel = 0;

        public CSharpCodeWriter(string outputPath)
        {
            _sw = File.CreateText(outputPath);
        }

        public void Using(string ns)
        {
            WriteIndented($"using {ns};");
        }

        public void PushBlock(string blockHeader)
        {
            WriteIndented(blockHeader);
            WriteIndented("{");
            _indentLevel += 4;
        }

        public void PopBlock()
        {
            _indentLevel -= 4;
            WriteIndented("}");
        }

        public void WriteLine(string text)
        {
            WriteIndented(text);
        }

        private void WriteIndented(string text)
        {
            for (int i = 0; i < _indentLevel; i++)
            {
                _sw.Write(' ');
            }
            _sw.WriteLine(text);
        }

        public void Dispose()
        {
            _sw.Dispose();
        }
    }
}
