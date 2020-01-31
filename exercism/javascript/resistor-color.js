export const colorCode = (color) => {
  for(var i = 0; i < COLORS.length; i++)
  {
    if (COLORS[i] === color) return i;
  }
};

export const COLORS = ["black","brown","red","orange","yellow","green","blue","violet","grey","white"];

