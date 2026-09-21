using System;

namespace AssetStudio
{
    public interface IUnityCN
    {
        void DecryptBlock(Span<byte> bytes, int size, int index);
    }
}
