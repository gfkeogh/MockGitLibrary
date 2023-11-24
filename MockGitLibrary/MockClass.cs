using System;

namespace MockGitLibrary;

/// <summary>
/// This is a mock class.
/// </summary>
public class MockClass
{
	/// <summary>
	/// This is a mock method.
	/// </summary>
	/// <returns>A random integer.</returns>
	public int GetRand() => Random.Shared.Next();
}
