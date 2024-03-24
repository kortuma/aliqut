var values = new[]
{
    (new[] { 1, 2, 3 }, "foo"),
    (new[] { 4, 5, 6 }, "bar"),
    (new[] { 7, 8, 9 }, "baz")
};

var innerRepository = new InnerRepository();
innerRepository.Insert(values.Select(x => (new[] { x.Item1[0] }, x.Item2)));
