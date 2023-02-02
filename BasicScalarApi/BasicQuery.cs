
public class BasicQuery
{
    [GraphQLType<UnsignedIntType>]
    [GraphQLName("number")]
    public uint GetNumber => 123;
}
