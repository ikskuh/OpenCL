#ifndef _GRAPHICS_H_
#define _GRAPHICS_H_

typedef struct
{
	struct 
	{
		float r;
		float g;
		float b;
		float a;
	};
	float4 rgba;
} Color;

__constant Color COLOR_RED = { 1.0f, 0.0f, 0.0f, 1.0f };
__constant Color COLOR_BLUE = { 0.0f, 0.0f, 1.0f, 1.0f };

/**
 * Converts a color to 
 */
uchar4 color_to_bits(Color color)
{
	return (uchar4)(
		(uchar)clamp(255.0f * color.b, 0.0f, 255.0f),
		(uchar)clamp(255.0f * color.g, 0.0f, 255.0f),
		(uchar)clamp(255.0f * color.r, 0.0f, 255.0f),
		(uchar)clamp(255.0f * color.a, 0.0f, 255.0f));
}

Color bits_to_color(uchar4 color)
{
	Color c;
	c.r = color.z / 255.0f;
	c.g = color.y / 255.0f;
	c.b = color.x / 255.0f;
	c.a = color.w / 255.0f;
	return c;
}

#endif // #ifndef _GRAPHICS_H_