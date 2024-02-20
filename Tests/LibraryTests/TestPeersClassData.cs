using System.Collections;
using Library;
namespace Tests.LibraryTests;
public class TestPeersClassData : IEnumerable<object[]>
{
    private readonly List<object[]> _data = new List<object[]>()
    {

        new object[] { 4},
        new object[] {236},
        new object[] {204},
        new object[] {240},
        new object[] {8},
        new object[] {80 }

    };

    public IEnumerator<object[]> GetEnumerator()
    {
        return _data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
