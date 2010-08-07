require 'rubygems'
require 'albacore'

rakefile = __FILE__
@home_dir = "#{rakefile}/../.."

task :default => :test

desc "show local variables"
task :show do
  puts "@home_dir: \t#{@home_dir}"
end

desc "clean and build"
msbuild :build => [:clean] do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Build
  msb.solution = "#{@home_dir}/app/RhinoSpike/RhinoSpike.sln"
end

msbuild :clean do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Clean
  msb.solution = "#{@home_dir}/app/RhinoSpike/RhinoSpike.sln"
end

desc "run tests"
task :test, :output_location, :needs => :build do |t, args|
  args.with_defaults(:output_location => :html)

  if args[:output_location] == 'html' then
    @output_target = "--html #{@home_dir}/rpt/specs.html"
  end

  run_tests_and_direct_output
end

desc "show args"
task :show_args, :arg1 do |t, args|
  args.with_defaults(:arg1 => :html)
  puts "args[:arg1]: [#{args[:arg1]}]"
  puts "Args were #{args}"
end

def run_tests_and_direct_output
  sh "#{@home_dir}/tools_bundle/mspec/mspec #{@output_target} #{@home_dir}/test/RhinoSpike.Test/bin/Debug/RhinoSpike.Test.dll"
end
