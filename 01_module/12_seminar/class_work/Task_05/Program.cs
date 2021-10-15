using System;
using System.Text.RegularExpressions;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. At urna condimentum mattis pellentesque id. Dictumst vestibulum rhoncus est pellentesque elit. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Non quam lacus suspendisse faucibus interdum. A condimentum vitae sapien pellentesque habitant morbi tristique senectus et. Venenatis tellus in metus vulputate eu scelerisque felis imperdiet. At ultrices mi tempus imperdiet nulla malesuada pellentesque elit. In hendrerit gravida rutrum quisque. Mattis nunc sed blandit libero volutpat sed cras. Tincidunt augue interdum velit euismod. Sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus. Scelerisque in dictum non consectetur a erat nam. Posuere lorem ipsum dolor sit amet consectetur. Iaculis urna id volutpat lacus. Massa sed elementum tempus egestas. Enim sed faucibus turpis in eu mi bibendum neque. Massa tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada. Eros in cursus turpis massa tincidunt. Convallis convallis tellus id interdum velit laoreet id. Dolor sit amet consectetur adipiscing elit pellentesque. Non pulvinar neque laoreet suspendisse. Commodo ullamcorper a lacus vestibulum sed arcu non odio euismod. Luctus accumsan tortor posuere ac. Velit euismod in pellentesque massa placerat duis ultricies. Magnis dis parturient montes nascetur ridiculus mus mauris. Quis ipsum suspendisse ultrices gravida dictum fusce ut placerat. Tortor dignissim convallis aenean et tortor at risus. Sed augue lacus viverra vitae congue eu consequat 4324 3 2 4 324349839024 234 32 432ac felis. Duis convallis convallis tellus id interdum velit laoreet id donec. Vel eros donec ac odio tempor orci dapibus ultrices. Urna cursus eget nunc scelerisque viverra mauris in aliquam sem. Ante in nibh mauris cursus mattis molestie a. Lectus magna fringilla urna porttitor rhoncus dolor purus non. Id neque aliquam vestibulum morbi blandit cursus risus.";
            var reg = new Regex(@"[0-9]+");
            var matches = reg.Match(s);
            Console.WriteLine(matches);
        }
    }
}