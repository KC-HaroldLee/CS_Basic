using System.Drawing;

class Card
{
    public string owner
    {
        set { owner = value; }
        get { return owner; }
    } // ';'이 붙지 않아도 되나보다
    
    public int no
    {
        set { no = value; }
        get { return no; }
    }

}